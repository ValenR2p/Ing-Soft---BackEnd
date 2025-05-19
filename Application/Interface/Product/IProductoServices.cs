using Application.Request;
using Application.Response;

namespace Application.Interface.Product
{
    public interface IProductServices
    {
        Task<ProductResponse> CreateProduct(ProductRequest request);
        Task<ProductResponse> UpdateProduct(ProductRequest request, int ProductId);
        Task<ProductResponse> DeleteProduct(int id);
        Task<List<ProductResponse>> GetAll();
        Task<ProductResponse> GetById(int id);
    }
}
