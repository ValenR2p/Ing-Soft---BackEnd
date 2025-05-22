using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IDetalleOrdenMapper
    {
        Task<List<OrderDetailResponse>> GetOrderDetails(List<DetalleOrden> orderDetails);
        Task<OrderDetailResponse> GetOneOrderDetail(DetalleOrden orderDetail);
    }
}
