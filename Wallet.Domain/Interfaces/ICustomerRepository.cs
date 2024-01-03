using Wallet.Domain.Entities;

namespace Wallet.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        bool DeleteCustomer(int customerId);
        bool DeleteCustomer(Customer customer);
        List<Customer> GetAllCustomer();
        Guid GetCustomerIdByName(string name);
        string GetCustomerNameById(Guid customerId);
        IEnumerable<Customer> GetCustomerByFilter(string parameter);
        Customer GetCustomerById(int customerId);
        List<Customer> GetNameCustomer(string filter = "");
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
    }
}
