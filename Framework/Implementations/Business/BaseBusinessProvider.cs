using Framework.Abstracts.Business;
using Framework.Abstracts.Models;
using Framework.Implementations.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framework.Implementations.Business
{
    public class BaseBusinessProvider<T> : DataAccessProvider<T>, IBusinessProvider<T> where T : class, IBusinessModel
    {
        public BaseBusinessProvider(DbContext dbc) : base(dbc)
        {
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Query(predicate);
        }

        public T Save(T entity)
        {
            T result = null;

            if (entity.Id != 0)
            {
                result = Update(entity).Entity;
            }
            else
            {
                result = Add(entity).Entity;
            }

            return result;
        }

        public T Delete(long? id)
        {
            T result = null;

            var currentEntity = Query(x => x.Id == id).FirstOrDefault();
            if (currentEntity != null)
            {
                result = Remove(currentEntity).Entity;
            }

            return result;
        }
    }
}
