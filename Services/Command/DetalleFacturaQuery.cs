using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class DetalleFacturaCommand
    {
        private readonly ApiContext _context;
        public DetalleFacturaCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertFactureDetail(Cobranza factureDetail)
        {
            _context.Add(factureDetail);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteFactureDetail(int id)
        {
            var factureDetail = await _context.FactureDetail.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateFactureDetail(DetalleFactura factureDetail)
        {
            _context.Update(factureDetail);
            await _context.SaveChangesAsync();
        }
    }
}
