using Framework.Abstracts.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framework.Abstracts.DataAccess
{
    public abstract class BaseDataAccessProvider<T> where T : class, IBusinessModel
    {
        abstract public EntityEntry<T> Add(T model);
        abstract public EntityEntry<T> Update(T model);
        abstract public EntityEntry<T> Remove(T model);
        abstract public IQueryable<T> Query();
        abstract public IQueryable<T> Query(Expression<Func<T, bool>> predicate);
    }
}
