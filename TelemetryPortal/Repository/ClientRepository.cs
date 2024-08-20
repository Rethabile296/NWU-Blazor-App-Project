using Microsoft.EntityFrameworkCore;
using TelemetryPortal.Data;
using TelemetryPortal.Models;


namespace TelemetryPortal.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        private readonly TechtrendsContext _context;

        public ClientRepository(TechtrendsContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> Get(Guid clientId)
        {
            return await _context.Clients.FindAsync(clientId);
        }

        public async Task Create(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid clientId)
        {
            var client = await _context.Clients.FindAsync(clientId);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
    }
}
