using Application.Interface.Order;
using Application.Interface.OrderDetail;
using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Azure.Core;
using Domain.Models;

namespace Application.UseCase
{
    public class OrderDetailServices : IOrdenDetalleServices
    {
        private readonly IOrdenDetalleQuery _query;
        private readonly IOrdenDetalleCommand _command;
        private readonly IDetalleOrdenMapper _mapper;
        public OrderDetailServices(IOrdenDetalleQuery query, IOrdenDetalleCommand command, IDetalleOrdenMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }

        public async Task<OrderDetailResponse> CreateOrderDetail(OrderDetailRequest request)
        {
            var newOrderDetail = new DetalleOrden
            {
                OrderId = request.OrderId,
                Quantity = request.Quantity,
                UnitCost = request.UnitCost,
                ProductId = request.ProductId,
            };

            await _command.InsertOrderDetail(newOrderDetail);
            return await _mapper.GetOneOrderDetail(newOrderDetail);
        }

        public async Task<OrderDetailResponse> UpdateOrderDetail(OrderDetailRequest request, int OrderDetailId)
        {
            var orderDetail = await _query.GetById(OrderDetailId);
            if (orderDetail != null)
            {
                orderDetail.OrderId = request.OrderId;
                orderDetail.Quantity = request.Quantity;
                orderDetail.UnitCost = request.UnitCost;
                orderDetail.ProductId = request.ProductId;
            }
            else 
            {
                throw new Exception("This order doesn´t exist");
            }

            await _command.UpdateOrderDetail(orderDetail);
            return await _mapper.GetOneOrderDetail(orderDetail);
        }

        public async Task<OrderDetailResponse> DeleteOrderDetail(int Id)
        {
            var orderDetail = await _query.GetById(Id);
            if (orderDetail != null)
            {
                await _command.DeleteOrderDetail(Id);
            }
            else
            {
                throw new Exception("This order doesn´t exist");
            }

            return await _mapper.GetOneOrderDetail(orderDetail);
        }

        public async Task<List<OrderDetailResponse>> GetAll()
        {
            var orderDetails = await _query.GetAll();
            return await _mapper.GetOrderDetails(orderDetails);
        }

        public async Task<OrderDetailResponse> GetById(int Id)
        {
            var orderDetail = await _query.GetById(Id);
            return await _mapper.GetOneOrderDetail(orderDetail);
        }

        
    }
}
