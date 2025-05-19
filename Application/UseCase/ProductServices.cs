using Application.Interface.Product;
using Application.Mapper.IMapper;
using Application.Request;
using Domain.Models;
using Application.Response;

namespace Application.UseCase
{
    public class ProductServices : IProductServices
    {
        private readonly IProductoQuery _query;
        private readonly IProductoCommand _command;
        private readonly IProductMapper _mapper;

        public ProductServices(IProductoQuery query, IProductoCommand command, IProductMapper mapper) {
            _query = query;
            _command = command;
            _mapper = mapper;
        }

        public async Task<ProductResponse> CreateProduct(ProductRequest request)
        {
            var newProduct = new Producto
            {
                Name = request.Name,
                Price = request.Price,
            };

            await _command.InsertProduct(newProduct);
            return await _mapper.GetOneProduct(newProduct);
        }

        public async Task<ProductResponse> UpdateProduct(ProductRequest request, int ProductId)
        {
            var product = await _query.GetById(ProductId);
            if (product != null)
            {
                product.Name = request.Name;
                product.Price = request.Price;
            }
            else 
            {
                throw new Exception("This product doesn´t exist");
            }

            await _command.UpdateProduct(product);
            return await _mapper.GetOneProduct(product);
        }

        public async Task<ProductResponse> DeleteProduct(int Id)
        {
            var product = await _query.GetById(Id);
            if (product != null)
            {
                await _command.DeleteProduct(product.Id);
            }
            else
            {
                throw new Exception("This product doesn´t exist");
            }

            return await _mapper.GetOneProduct(product);
        }

        public async Task<List<ProductResponse>> GetAll()
        {
            var products = await _query.GetAll();
            return await _mapper.GetProducts(products);
        }

        public async Task<ProductResponse> GetById(int Id)
        {
            var product = await _query.GetById(Id);
            return await _mapper.GetOneProduct(product);
        }

        
    }
}
