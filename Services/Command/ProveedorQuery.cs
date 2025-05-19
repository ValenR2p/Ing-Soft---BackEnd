using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ProveedorCommand
    {
        private readonly ApiContext _context;
        public ProveedorCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertFacture(Proveedor provider)
        {
            _context.Add(provider);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteFacture(int id)
        {
            var provider = await _context.Providers.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateFacture(Proveedor provider)
        {
            _context.Update(provider);
            await _context.SaveChangesAsync();
        }
    }
}
