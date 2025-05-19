using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class OrdenDeCompraCommand
    {
        private readonly ApiContext _context;
        public OrdenDeCompraCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertFacture(OrdenDeCompra order)
        {
            _context.Add(order);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteFacture(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateFacture(OrdenDeCompra order)
        {
            _context.Update(order);
            await _context.SaveChangesAsync();
        }
    }
}