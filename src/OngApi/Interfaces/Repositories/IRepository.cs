namespace OngApi.Interfaces.Repositories
{
    public interface IRepository<T> 
    {
        T Insert(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
