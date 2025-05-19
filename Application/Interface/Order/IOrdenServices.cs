using Application.Request;
using Application.Response;

namespace Application.Interface.Order
{
    public interface IOrdenServices
    {
        Task<OrderResponse> CreateOrder(OrderRequest request);
        Task<OrderResponse> UpdateOrder(OrderRequest request, int OrderId);
        Task<OrderResponse> DeleteOrder(int id);
        Task<List<OrderResponse>> GetAll();
        Task<OrderResponse> GetById(int id);
    }
}
