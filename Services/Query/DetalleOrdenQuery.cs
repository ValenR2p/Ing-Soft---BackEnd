using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Interface.OrderDetail;

namespace Infrastructure.Query
{
    public class DetalleOrdenQuery : IOrdenDetalleQuery
    {
        private readonly ApiContext _context;
        public DetalleOrdenQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<DetalleOrden>> GetAll()
        {
            var orderDetails = await _context.OrderDetail.ToListAsync();
            return orderDetails;
        }
        public async Task<DetalleOrden> GetById(int id)
        {
            var orderDetail = await _context.OrderDetail
                .FirstOrDefaultAsync(c => c.Id == id);
            return orderDetail;
        }
    }
}
