using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respository.IRespository;
using Bulky.Models.Models;

namespace Bulky.DataAccess.Respository
{
    public class CategoryRespository : Respository<Category>, ICategoryRespository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
