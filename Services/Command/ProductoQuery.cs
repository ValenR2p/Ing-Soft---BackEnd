using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ProductoCommand
    {
        private readonly ApiContext _context;
        public ProductoCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertFacture(Producto product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteFacture(int id)
        {
            var product = await _context.Products.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateFacture(Producto product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
