using Bulky.Models.Models;

namespace Bulky.DataAccess.Respository.IRespository
{
    public interface ICategoryRespository : IRespository<Category>
    {
        void Update(Category category);

    }
}
