using Wallet.Domain.Entities;

namespace Wallet.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        bool DeleteCustomer(Guid customerId);
        bool DeleteCustomer(Customer customer);
        List<Customer> GetAllCustomer();
        Guid GetCustomerIdByName(string name);
        string GetCustomerNameById(Guid customerId);
        IEnumerable<Customer> GetCustomerByFilter(string parameter);
        Customer GetCustomerById(Guid customerId);
        List<Customer> GetNameCustomer(string filter = "");
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
    }
}
