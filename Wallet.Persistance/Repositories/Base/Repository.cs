using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Wallet.Domain.Entities.Base;
using Wallet.Domain.Interfaces.Base;

namespace Wallet.Persistance.Repositories.Base
{
    public class Repository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbset;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbset = _dbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbset;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }

        public virtual TEntity GetById(TKey Id)
        {
            return _dbset.Find(Id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }
        public virtual void Delete(TKey Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
}
