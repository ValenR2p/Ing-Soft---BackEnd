using Application.Request;
using Application.Response;

namespace Application.Interface.OrderDetail
{
    public interface IOrdenDetalleServices
    {
        Task<OrderDetailResponse> CreateOrderDetail(OrderDetailRequest request);
        Task<OrderDetailResponse> UpdateOrderDetail(OrderDetailRequest request, int OrderDetailId);
        Task<OrderDetailResponse> DeleteOrderDetail(int id);
        Task<List<OrderDetailResponse>> GetAll();
        Task<OrderDetailResponse> GetById(int id);
    }
}
