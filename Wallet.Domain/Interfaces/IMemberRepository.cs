

using Wallet.Domain.Entities;

namespace Wallet.Domain.Interfaces
{
    public interface IMemberRepository
    {
        bool DeleteCustomer(int customerId);
        bool DeleteCustomer(Member customer);
        List<Member> GetAllMember();
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int customerId);
        IEnumerable<Member> GetMemberByFilter(string parameter);
        Member GetMemberById(int customerId);
        List<ListCustomerViewModel> GetNameMember(string filter = "");
        bool InsertCustomer(Member customer);
        bool UpdateCustomer(Member customer);
    }
}
