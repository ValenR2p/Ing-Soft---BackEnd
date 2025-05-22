using Application.Interface.Order;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class OrdenDeCompraCommand : IOrdenCommand
    {
        private readonly ApiContext _context;
        public OrdenDeCompraCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertOrder(OrdenDeCompra order)
        {
            _context.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrder(OrdenDeCompra order)
        {
            _context.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            await _context.SaveChangesAsync();
        }
    }
}