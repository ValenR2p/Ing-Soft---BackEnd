using Domain.Models;

namespace Application.Interface.OrderDetail
{
    public interface IOrdenDetalleCommand
    {
        Task InsertOrderDetail(DetalleOrden orderDetail);
        Task UpdateOrderDetail(DetalleOrden orderDetail);
        Task DeleteOrderDetail(int id);
    }
}
