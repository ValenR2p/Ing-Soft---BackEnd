using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;

namespace Infrastructure.Query
{
    internal class FormaCobranzaQuery
    {
        private readonly ApiContext _context;
        public FormaCobranzaQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<FormaCobranza>> GetAll()
        {
            var purchaseMethods = await _context.PurchaseMethods.ToListAsync();
            return purchaseMethods;
        }
        public async Task<FormaCobranza> GetById(int id)
        {
            var purchaseMethod = await _context.PurchaseMethods
                .FirstOrDefaultAsync(c => c.Id == id);
            return purchaseMethod;
        }
    }
}
