using Application.Interface.Facture;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class FacturaCommand : IFacturaCommand
    {
        private readonly ApiContext _context;
        public FacturaCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertFacture(Factura facture)
        {
            _context.Add(facture);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteFacture(int id)
        {
            var facture = await _context.Factures.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateFacture(Factura facture)
        {
            _context.Update(facture);
            await _context.SaveChangesAsync();
        }
    }
}