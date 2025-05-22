using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Interface.Product;

namespace Infrastructure.Query
{
    public class ProductoQuery : IProductoQuery
    {
        private readonly ApiContext _context;
        public ProductoQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
        public async Task<Producto> GetById(int id)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(c => c.Id == id);
            return product;
        }
    }
}
