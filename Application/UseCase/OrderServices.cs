using Application.Interface.Order;
using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Domain.Models;

namespace Application.UseCase
{
    public class OrderServices : IOrdenServices
    {
        private readonly IOrdenQuery _query;
        private readonly IOrdenCommand _command;
        private readonly IOrdenMapper _mapper;
        public OrderServices(IOrdenQuery query, IOrdenCommand command, IOrdenMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }
        public async Task<OrderResponse> CreateOrder(OrderRequest request)
        {
            var newOrder = new OrdenDeCompra
            {
                Amount = request.Amount,
            };

            await _command.InsertOrder(newOrder);
            return await _mapper.GetOneOrder(newOrder);
        }

        public async Task<OrderResponse> UpdateOrder(OrderRequest request, int OrderId)
        {
            var Order = await _query.GetById(OrderId);
            if (Order != null){
                Order.Amount = request.Amount;
            }
            else
            {
                throw new Exception("This order doesn´t exist");
            }

            await _command.UpdateOrder(Order);
            return await _mapper.GetOneOrder(Order);
        }

        public async Task<OrderResponse> DeleteOrder(int Id)
        {
            var order = await _query.GetById(Id);
            if (order != null)
            {
                await _command.DeleteOrder(order.Id);
            }
            else
            {
                throw new Exception("This order doesn´t exist");
            }
            return await _mapper.GetOneOrder(order);
        }

        public async Task<List<OrderResponse>> GetAll()
        {
            var orders = await _query.GetAll();
            return await _mapper.GetOrders(orders);
        }

        public async Task<OrderResponse> GetById(int Id)
        {
            var order = await _query.GetById(Id);
            return await _mapper.GetOneOrder(order);
        }
    }
}
