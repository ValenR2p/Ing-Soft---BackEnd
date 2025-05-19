using Application.Interface.Cliente;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ClienteCommand : IClienteCommand
    {
        private readonly ApiContext _context;
        public ClienteCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertClient(Cliente client)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateClient(Cliente client)
        {
            _context.Update(client);
            await _context.SaveChangesAsync();
        }
    }
}
