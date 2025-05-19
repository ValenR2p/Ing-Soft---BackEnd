using Domain.Models;

namespace Application.Interface.Product
{
    public interface IProductoQuery
    {
        Task<List<Producto>> GetAll();
        Task<Producto> GetById(int id);       
    }
}
