using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class DetalleOrdenCommand
    {
        private readonly ApiContext _context;
        public DetalleOrdenCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertOrderDetail(DetalleOrden orderDetail)
        {
            _context.Add(orderDetail);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteOrderDetail(int id)
        {
            var orderDetail = await _context.OrderDetail.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateOrderDetail(DetalleOrden orderDetail)
        {
            _context.Update(orderDetail);
            await _context.SaveChangesAsync();
        }
    }
}
