using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels;

namespace Accounting.DataLayer.Repositories
{
    //make public for use class in other layers
    public interface ICustomerRepository
    {
        //Create list  & Type: Customers
        //ایجاد لیستی از نوع کاستومرز
        //به نام GetAllcustomers
        List<Customers> GetAllCustomers();
        //جستجو - برگرداندن مقداری
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNameCustomers(string filter = ""); 
        //ایجاد یک نوع از کاستومرز مطابق با نام عملی که میخواهیم انجام دهیم
        //هر جا از این نمونه استفاده شد باید متغیری برای دریافت مقدار تعریف شود
        Customers GetCustomersById(int customerId);
        //create field name same by her do//هر جایی از این فیلد استفاده شد حتما باید یه نمونه از کاستومرز ک خودکار تولید شد ایجاد کنه و بهش مقدار بده
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int customerId);
    }
}
