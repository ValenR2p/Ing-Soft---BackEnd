using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Interface.Facture;

namespace Infrastructure.Query
{
    public class FacturaQuery : IFacturaQuery
    {
        private readonly ApiContext _context;
        public FacturaQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<Factura>> GetAll()
        {
            var factures = await _context.Factures.ToListAsync();
            return factures;
        }
        public async Task<Factura> GetById(int id)
        {
            var facture = await _context.Factures
                .FirstOrDefaultAsync(c => c.Id == id);
            return facture;
        }
    }
}
