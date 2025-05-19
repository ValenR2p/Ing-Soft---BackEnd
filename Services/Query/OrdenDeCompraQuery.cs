using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;

namespace Infrastructure.Query
{
    internal class OrdenDeCompraQuery
    {
        private readonly ApiContext _context;
        public OrdenDeCompraQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<OrdenDeCompra>> GetAll()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }
        public async Task<OrdenDeCompra> GetById(int id)
        {
            var order = await _context.Orders
                .FirstOrDefaultAsync(c => c.Id == id);
            return order;
        }
    }
}
