using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Dtos;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Persistance.Common;
using Wallet.Persistance.Repositories.Base;

namespace Wallet.Persistance.Repositories
{
    public class CustomerRepository : Repository<Guid, Customer>, ICustomerRepository
    {
        private readonly WalletDbContext _dbContext;

        public CustomerRepository(WalletDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }
        public Customer GetCustomerById(Guid customerId)
        {
            return _dbContext.Customers.Find(customerId);
        }
        public bool InsertCustomer(Customer customer)
        {
            try
            {
                _dbContext.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customer customer)
        {
            var local = _dbContext.Set<Customer>()
                         .Local
                         .FirstOrDefault(f => f.Id == customer.Id);
            if (local != null)
            {
                _dbContext.Entry(local).State = EntityState.Detached;
            }
            _dbContext.Entry(customer).State = EntityState.Modified;
            return true;
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                _dbContext.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool DeleteCustomer(Guid customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Customer> GetCustomerByFilter(string parameter)
        {
            return _dbContext.Customers
                .Where(c => c.FirstName.Contains(parameter)
                || c.Email.Contains(parameter)
                || c.Mobile.Contains(parameter)
                || c.LastName.Contains(parameter)).ToList();
        }

        public async Task<Guid> GetCustomerIdByName(string name)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(c => c.FirstName == name);
            if (customer != null)
            {
                return customer.Id;
            }
            throw new InvalidOperationException($"No customer found with the name '{name}'.");
        }
        public string GetCustomerNameById(Guid customerId)
        {
            return _dbContext.Customers.Find(customerId).FirstName ??
                throw new Exception("Not Found! ");
        }

        public async Task<List<CustomerDto>> GetNameCustomer(string filter = "")
        {
            if (filter == "")
            {
                return await _dbContext.Customers.Select(c => new CustomerDto()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                }).ToListAsync();
            }

            return await _dbContext.Customers
                .Where(c => c.FirstName.Contains(filter))
                .Select(c => new CustomerDto()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                }).ToListAsync();
        }
    }
}
