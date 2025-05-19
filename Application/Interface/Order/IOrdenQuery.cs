using Domain.Models;

namespace Application.Interface.Order
{
    public interface IOrdenQuery
    {
        Task<List<OrdenDeCompra>> GetAll();
        Task<OrdenDeCompra> GetById(int id);       
    }
}
