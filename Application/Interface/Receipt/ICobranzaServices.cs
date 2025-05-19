using Application.Request;

namespace Application.Interface.Receipt
{
    public interface ICobranzaServices
    {
        Task<ReceiptResponse> CreateReceipt(ReceiptRequest request);
        Task<ReceiptResponse> UpdateReceipt(ReceiptRequest request, int ReceiptId);
        Task<ReceiptResponse> DeleteReceipt(int id);
        Task<List<ReceiptResponse>> GetAll();
        Task<ReceiptResponse> GetById(int id);
    }
}
