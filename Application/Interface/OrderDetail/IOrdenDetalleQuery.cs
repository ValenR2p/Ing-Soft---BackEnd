using Domain.Models;

namespace Application.Interface.OrderDetail
{
    public interface IOrdenDetalleQuery
    {
        Task<List<DetalleOrden>> GetAll();
        Task<DetalleOrden> GetById(int id);       
    }
}
