using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class FormaCobranzaCommand
    {
        private readonly ApiContext _context;
        public FormaCobranzaCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertFacture(FormaCobranza purchaseMethod)
        {
            _context.Add(purchaseMethod);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteFacture(int id)
        {
            var purchaseMethod = await _context.PurchaseMethods.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateFacture(FormaCobranza purchaseMethod)
        {
            _context.Update(purchaseMethod);
            await _context.SaveChangesAsync();
        }
    }
}
