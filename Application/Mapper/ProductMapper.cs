using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    public class ProductMapper : IProductMapper
    {
        public Task<ProductResponse> GetOneProduct(Producto product)
        {
            var response = new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
            };
                
            return Task.FromResult(response);
        }

        public Task<List<ProductResponse>> GetProducts(List<Producto> products)
        {
            List<ProductResponse> responses = new List<ProductResponse>();
            foreach (var product in products)
            {
                var response = new ProductResponse
                {
                    Id = product.Id,
                    Name = product.Name,
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }
    }
}
