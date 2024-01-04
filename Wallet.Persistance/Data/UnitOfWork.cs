using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Entities;
using Wallet.Domain.Entities.Base;
using Wallet.Domain.Interfaces;
using Wallet.Domain.Interfaces.Base;
using Wallet.Persistance.Common;
using Wallet.Persistance.Repositories;
using Wallet.Persistance.Repositories.Base;

namespace Wallet.Persistance.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WalletDbContext _walletDbContext;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(WalletDbContext walletDbContext)
        {
            _walletDbContext = walletDbContext;
            _repositories = new Dictionary<Type, object>();
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

        private IRepository<Guid, Transaction> _transactionRepository;
        public IRepository<Guid, Transaction> transactionRepository
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

        private IRepository<int, Login> _loginRepository;
        public IRepository<int, Login> LoginRepository
        {
            get
            {
                _loginRepository ??= new Repository<int, Login>(_walletDbContext);
                return _loginRepository;
            }
        }

        public IRepository<TKey, TEntity> GetRepository<TKey, TEntity>() where TEntity : BaseEntity<TKey>
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IRepository<TKey, TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new Repository<TKey, TEntity>(_walletDbContext);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
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
