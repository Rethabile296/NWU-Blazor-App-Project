using System.Collections.Generic;

namespace TelemetryPortal.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
