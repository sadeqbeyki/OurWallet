﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    //public
    public class GenericRepository<TEntity> where TEntity:class
    {
        private Accounting_DBEntities _db;
        //tables
        private DbSet<TEntity> _dbset;

        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbset = _db.Set<TEntity>();
        }

        //ienumerable is interface for all generic list
        //میتواند به تمام فرزندانش تغییر قیافه دهد
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            //lasy query
            IQueryable<TEntity> query = _dbset;
            if(where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
        
        //object is paret of all dataType
        public virtual TEntity GetById(object Id)
        {
            return _dbset.Find(Id);
        }

        //virtual = override کردن = تغییر رفتار
        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete (TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }
        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
}
