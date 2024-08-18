using TelemetryPortal.Models;

namespace TelemetryPortal.Repository
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> Get(Guid clientId);
        Task Create(Client client);
        Task Update(Client client);
        Task Delete(Guid clientId);
    }
}
