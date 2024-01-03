using System.Linq.Expressions;
using Wallet.Domain.Entities.Base;

namespace Wallet.Domain.Interfaces.Base
{
    public interface IRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null);
        TEntity GetById(TKey Id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TKey Id);
    }
}
