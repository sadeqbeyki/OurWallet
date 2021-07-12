using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using System.Data.Entity;
using Accounting.ViewModels;


namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        // Accounting_DBEntities context
        //Accounting_DBEntities db = new Accounting_DBEntities();
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        //remember: you should use return to recive reply
        //متدی از نوع لیست تعریف و  قوانین و دستورات رو ایجاد میکنیم
        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomersById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            //try
            //{
            //به جای یوزینگ از این روش بهره میبریم تا ارتباط کانتکست رو قطع کنیم و به ویرایش بسپریم
            var local = db.Set<Customers>()
                         .Local
                         .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
            //    }
            //    catch
            //    {
            //        return false;
            //    }
        }

        public bool DeleteCustomer(Customers customer)
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
                //var or Customers
                var customer = GetCustomersById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName
            }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }
    }
}
