using Application.Interface.Product;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ProductoCommand : IProductoCommand
    {
        private readonly ApiContext _context;
        public ProductoCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertProduct(Producto product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Producto product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            await _context.SaveChangesAsync();
        }
    }
}
