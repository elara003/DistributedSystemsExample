using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DDD;

namespace Boilerplate.Repository
{
    public interface IRepository<T> where T : AggregateRoot
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> query);

        void Insert(T item);
    }
}
