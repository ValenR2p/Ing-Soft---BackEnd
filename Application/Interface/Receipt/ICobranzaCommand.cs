using Domain.Models;

namespace Application.Interface.Receipt
{
    public interface ICobranzaCommand
    {
        Task InsertReceipt(Cobranza receipt);
        Task UpdateReceipt(Cobranza receipt);
        Task DeleteReceipt(int id);
    }
}
