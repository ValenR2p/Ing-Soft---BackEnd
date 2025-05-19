using Domain.Models;

namespace Application.Interface.Order
{
    public interface IOrdenCommand
    {
        Task InsertOrder(OrdenDeCompra order);
        Task UpdateOrder(OrdenDeCompra order);
        Task DeleteOrder(int id);
    }
}
