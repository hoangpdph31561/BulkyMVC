using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respository.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bulky.DataAccess.Respository
{
    public class Respository<T> : IRespository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbSet;
        public Respository(ApplicationDbContext db)
        {
            _db = db;
            this._dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> querry = _dbSet;
            querry = querry.Where(filter);
            return querry.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> querry = _dbSet;
            return querry.ToList();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
