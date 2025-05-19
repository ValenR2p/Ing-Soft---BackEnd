using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IProductMapper
    {
        Task<List<ProductResponse>> GetProducts(List<Producto> products);
        Task<ProductResponse> GetOneProduct(Producto product);
    }
}
