using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces;
using Wallet.Persistance.Common;
using Wallet.Persistance.Repositories;
using Wallet.Persistance.Repositories.Base;

namespace Wallet.Persistance.Data
{
    public class UnitOfWork : IDisposable
    {
        private readonly WalletDbContext _walletDbContext;

        public UnitOfWork(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
        }

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_walletDbContext);

                }
                return _customerRepository;
            }
        }

        private Repository<Guid, Transaction> _transactionRepository;
        public Repository<Guid, Transaction> transactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new Repository<Guid, Transaction>(_walletDbContext);
                }
                return _transactionRepository;
            }
        }

        private Repository<int, Login> _loginRepository;
        public Repository<int, Login> LoginRepository
        {
            get
            {
                _loginRepository ??= new Repository<int, Login>(_walletDbContext);
                return _loginRepository;
            }
        }
        public void Save()
        {
            _walletDbContext.SaveChanges();
        }
        public void Dispose()
        {
            _walletDbContext.Dispose();
        }
    }
}
