using Application.Interface.Provider;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ProveedorCommand : IProveedorCommand
    {
        private readonly ApiContext _context;
        public ProveedorCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertProvider(Proveedor provider)
        {
            _context.Add(provider);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProvider(Proveedor provider)
        {
            _context.Update(provider);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProvider(int id)
        {
            var provider = await _context.Providers.FindAsync(id);
            await _context.SaveChangesAsync();
        }
    }
}
