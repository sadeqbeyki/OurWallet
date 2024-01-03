using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;

namespace Wallet.Persistance.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public List<Member> GetAllMember()
        {
            return db.Member.ToList();
        }
        public Member GetMemberById(int customerId)
        {
            return db.Member.Find(customerId);
        }
        public bool InsertCustomer(Member customer)
        {
            try
            {
                db.Member.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Member customer)
        {
            var local = db.Set<Member>()
                         .Local
                         .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
        }
        public bool DeleteCustomer(Member customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetMemberById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Member> GetMemberByFilter(string parameter)
        {
            return db.Member.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }
        public List<ListCustomerViewModel> GetNameMember(string filter = "")
        {
            if (filter == "")
            {
                return db.Member.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }
            return db.Member.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName
            }).ToList();
        }
        public int GetCustomerIdByName(string name)
        {
            return db.Member.First(c => c.FullName == name).CustomerID;
        }
        public string GetCustomerNameById(int customerId)
        {
            return db.Member.Find(customerId).FullName;
        }
    }
}
