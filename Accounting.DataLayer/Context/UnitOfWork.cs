using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    //public | خروج از حافظه با اینترفیس فوق
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        //Interface
        private ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository 
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);

                }
                return _customerRepository;
            }
        }

        //generic
        private GenericRepository<Accounting> _accountingRepository;
        public GenericRepository<Accounting> AccuntingRepository 
        { 
            get 
            { 
                //null mean is = no create instanse from this repository
                if(_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting>(db);
                }
                return _accountingRepository;
            } 
        }

        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
