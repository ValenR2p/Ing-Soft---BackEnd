using Application.Request;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface ICobranzaMapper
    {
        Task<List<ReceiptResponse>> GetReceipts(List<Cobranza> receipt);
        Task<ReceiptResponse> GetOneReceipt(Cobranza receipt);
    }
}
