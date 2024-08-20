using TelemetryPortal.Models;

namespace TelemetryPortal.Repository
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<IEnumerable<Project>> GetAll();
        Task<Project> Get(Guid projectId);
        Task Create(Project project);
        Task Update(Project project);
        Task Delete(Guid projectId);
    }

}
