using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Interface.FactureDetail;

namespace Infrastructure.Query
{
    public class DetalleFacturaQuery : IFacturaDetalleQuery
    {
        private readonly ApiContext _context;
        public DetalleFacturaQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<DetalleFactura>> GetAll()
        {
            var factureDetails = await _context.FactureDetail.ToListAsync();
            return factureDetails;
        }
        public async Task<DetalleFactura> GetById(int id)
        {
            var factureDetail = await _context.FactureDetail
                .FirstOrDefaultAsync(c => c.Id == id);
            return factureDetail;
        }
    }
}
