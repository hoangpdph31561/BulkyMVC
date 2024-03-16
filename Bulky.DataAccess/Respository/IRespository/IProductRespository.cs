using Bulky.Models.Models;

namespace Bulky.DataAccess.Respository.IRespository
{
    public interface IProductRespository : IRespository<Product>
    {
        void Update(Product product);
    }
}
