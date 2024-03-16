namespace Bulky.DataAccess.Respository.IRespository
{
    public interface IUnitOfWork
    {
        ICategoryRespository Category { get; }
        void Save();
    }
}
