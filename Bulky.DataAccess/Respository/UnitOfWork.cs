using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respository.IRespository;

namespace Bulky.DataAccess.Respository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ICategoryRespository Category { get; private set; }
        public IProductRespository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRespository(_db);
            Product = new ProductRespository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
