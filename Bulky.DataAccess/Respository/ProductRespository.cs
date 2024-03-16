using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respository.IRespository;
using Bulky.Models.Models;


namespace Bulky.DataAccess.Respository
{
    public class ProductRespository : Respository<Product>, IProductRespository
    {
        private readonly ApplicationDbContext _db;

        public ProductRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            _db.Update(product);
        }
    }
}
