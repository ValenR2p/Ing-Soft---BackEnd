using Application.Interface.Receipt;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class CobranzaCommand : ICobranzaCommand
    {
        private readonly ApiContext _context;
        public CobranzaCommand(ApiContext context)
        {
            _context = context;
        }

        public async Task InsertReceipt(Cobranza receipt)
        {
            _context.Add(receipt);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteReceipt(int id)
        {
            var receipt = await _context.Receipts.FindAsync(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateReceipt(Cobranza receipt)
        {
            _context.Update(receipt);
            await _context.SaveChangesAsync();
        }
    }
}
