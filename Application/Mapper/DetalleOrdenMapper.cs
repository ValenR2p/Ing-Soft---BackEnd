using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    public class DetalleOrdenMapper : IDetalleOrdenMapper
    {
        public Task<List<OrderDetailResponse>> GetOrderDetails(List<DetalleOrden> orderDetails)
        {
            List<OrderDetailResponse> responses = new List<OrderDetailResponse>();
            foreach (var orderDetail in orderDetails)
            {
                var response = new OrderDetailResponse
                {
                    Id = orderDetail.Id,

                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<OrderDetailResponse> GetOneOrderDetail(DetalleOrden orderDetail)
        {
            var response = new OrderDetailResponse
            {
                Id = orderDetail.Id,
            };

            return Task.FromResult(response);
        }
    }
}
