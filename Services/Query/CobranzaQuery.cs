using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application.Interface.Receipt;

namespace Infrastructure.Query
{
    public class CobranzaQuery : ICobranzaQuery
    {
        private readonly ApiContext _context;
        public CobranzaQuery(ApiContext context)
        {
            _context = context;
        }

        public async Task<List<Cobranza>> GetAll()
        {
            var clients = await _context.Receipts.ToListAsync();
            return clients;
        }
        public async Task<Cobranza> GetById(int id)
        {
            var client = await _context.Receipts
                .FirstOrDefaultAsync(c => c.Id == id);
            return client;
        }
    }
}
