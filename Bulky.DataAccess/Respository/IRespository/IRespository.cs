﻿using System.Linq.Expressions;

namespace Bulky.DataAccess.Respository.IRespository
{
    public interface IRespository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void DeleteRange(IEnumerable<T> entity);
    }
}
