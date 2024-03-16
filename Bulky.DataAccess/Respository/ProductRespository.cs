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
            var productFromDb = _db.Products.FirstOrDefault(x => x.Id == product.Id);
            if (productFromDb != null)
            {
                if (productFromDb.ImgUrl != null)
                {
                    productFromDb.ImgUrl = product.ImgUrl;
                }
                productFromDb.Title = product.Title;
                productFromDb.Description = product.Description;
                productFromDb.Price = product.Price;
                productFromDb.ListPrice = product.ListPrice;
                productFromDb.Price100 = product.Price100;
                productFromDb.Price50 = product.Price50;
                productFromDb.ISBN = product.ISBN;
                productFromDb.Author = product.Author;
                productFromDb.CategoryId = product.CategoryId;
            }
        }
    }
}
