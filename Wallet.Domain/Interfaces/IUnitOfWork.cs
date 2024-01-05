using Wallet.Domain.Entities;
using Wallet.Domain.Entities.Base;
using Wallet.Domain.Interfaces.Base;

namespace Wallet.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        void Dispose();
        IRepository<TKey,TEntity> GetRepository<TKey, TEntity>() where TEntity : BaseEntity<TKey>;

        IAccountRepository AccountRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        ITransactionCategoryRepository TransactionCategoryRepository { get; }
        IRepository<int, Login> LoginRepository { get; }
        IRepository<Guid, Transaction> transactionRepository { get; }
        IRepository<int, TransactionType> transactionTypeRepository { get; }
    }
}
