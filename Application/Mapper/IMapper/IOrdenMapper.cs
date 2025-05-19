using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IOrdenMapper
    {
        Task<List<OrderResponse>> GetOrders(List<OrdenDeCompra> orders);
        Task<OrderResponse> GetOneOrder(OrdenDeCompra order);
    }
}
