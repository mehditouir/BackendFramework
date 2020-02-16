using Framework.Abstracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framework.Abstracts.Business
{
    public interface IBusinessProvider<T> where T : class, IBusinessModel
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Save(T entity);
        T Delete(long? id);
    }
}
