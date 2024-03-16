namespace Bulky.DataAccess.Respository.IRespository
{
    public interface IUnitOfWork
    {
        ICategoryRespository Category { get; }
        IProductRespository Product { get; }
        void Save();
    }
}
