using Domain.Models;

namespace Application.Interface.Product
{
    public interface IProductoCommand
    {
        Task InsertProduct(Producto product);
        Task UpdateProduct(Producto product);
        Task DeleteProduct(int id);
    }
}
