namespace TelemetryPortal.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task Create(T entity);
        Task Delete(Guid id);
        Task Update(T entity);
    }
}
