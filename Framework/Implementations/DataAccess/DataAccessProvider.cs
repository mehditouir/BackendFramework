using Framework.Abstracts.DataAccess;
using Framework.Abstracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framework.Implementations.DataAccess
{
    public abstract class DataAccessProvider<T> : BaseDataAccessProvider<T> where T : class, IBusinessModel
    {
        private DbContext _DbContext;

        public DataAccessProvider(DbContext dbc)
        {
            _DbContext = dbc;
        }

        public override EntityEntry<T> Add(T model)
        {
            var entity = _DbContext.Add(model);
            _DbContext.SaveChanges();
            return entity;
        }

        public override IQueryable<T> Query()
        {
            return _DbContext.Set<T>();
        }

        public override IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _DbContext.Set<T>().Where(predicate);
        }

        public override EntityEntry<T> Remove(T model)
        {
            var entity = _DbContext.Remove<T>(model);
            _DbContext.SaveChanges();
            return entity;
        }

        public override EntityEntry<T> Update(T model)
        {
            var entity = _DbContext.Update<T>(model);
            _DbContext.SaveChanges();
            return entity;
        }
    }
}
