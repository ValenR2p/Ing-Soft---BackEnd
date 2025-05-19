using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    public class OrdenMapper : IOrdenMapper
    {
        public Task<List<OrderResponse>> GetOrders(List<OrdenDeCompra> orders)
        {
            List<OrderResponse> responses = new List<OrderResponse>();
            foreach (var order in orders)
            {
                var response = new OrderResponse
                {
                    Id = order.Id,
                    Amount = order.Amount,
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<OrderResponse> GetOneOrder(OrdenDeCompra orden)
        {
            var response = new OrderResponse
            {
                Id = orden.Id,
                Amount = orden.Amount,
            };
            return Task.FromResult(response);
        }
    }
}
