using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Interface.Cliente;

namespace Infrastructure.Query
{
    public class ClienteQuery : IClienteQuery
    {
        private readonly ApiContext _context;
        public ClienteQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> GetAll()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
        }
        public async Task<Cliente> GetById(int id)
        {
            var client = await _context.Clients
                .FirstOrDefaultAsync(c => c.Id == id);
            return client;
        }
    }
}
