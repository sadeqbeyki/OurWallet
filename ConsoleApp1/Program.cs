using Accounting.DataLayer.Context;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();
            var list = db.CustomerRepository.GetAllCustomers();

            //Accounting_DBEntities db = new Accounting_DBEntities();
            //ICustomerRepository customer = new CustomerRepository(db);
            //Customers AddCustomer = new Customers()
            //{
            //    FullName = "جمشید هخامنشی",
            //    CustomerImage = "NoPhoto",
            //    Mobile = "00112233"
            //};
            //customer.InsertCustomer(AddCustomer);
            //customer.Save();

            //var list = customer.GetAllCustomers();

        }
    }
}
