using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;

namespace Infrastructure.Query
{
    public class ProveedorQuery
    {
        private readonly ApiContext _context;
        public ProveedorQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<Proveedor>> GetAll()
        {
            var providers = await _context.Providers.ToListAsync();
            return providers;
        }
        public async Task<Proveedor> GetById(int id)
        {
            var provider = await _context.Providers
                .FirstOrDefaultAsync(c => c.Id == id);
            return provider;
        }
    }
}
