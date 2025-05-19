using Application.Interface.Receipt;
using Application.Mapper.IMapper;
using Application.Request;
using Domain.Models;

namespace Application.UseCase
{
    public class ReceiptServices : ICobranzaServices
    {
        private readonly ICobranzaQuery _query;
        private readonly ICobranzaCommand _command;
        private readonly ICobranzaMapper _mapper;
        public ReceiptServices(ICobranzaQuery query, ICobranzaCommand command, ICobranzaMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }
        public async Task<ReceiptResponse> CreateReceipt(ReceiptRequest request)
        {
            var newReceipt = new Cobranza
            {
                FactureId = request.FactureId,
                Date = request.Date,
                Amount = request.Amount,
                PaymentMethod = request.PaymentMethod,
            };

            await _command.InsertReceipt(newReceipt);
            return await _mapper.GetOneReceipt(newReceipt);
        }
        public async Task<ReceiptResponse> UpdateReceipt(ReceiptRequest request, int ReceiptId)
        {
            var receipt = await _query.GetById(ReceiptId);
            if (receipt != null)
            {
                receipt.FactureId = request.FactureId;
                receipt.Date = request.Date;
                receipt.Amount = request.Amount;
                receipt.PaymentMethod = request.PaymentMethod;
            }
            else
            {
                throw new Exception("This Receipt doesn´t exist");
            }
            await _command.UpdateReceipt(receipt);
            return await _mapper.GetOneReceipt(receipt);
        }

        public async Task<ReceiptResponse> DeleteReceipt(int Id)
        {
            var receipt = await _query.GetById(Id);
            if (receipt != null)
            {
                await _command.DeleteReceipt(receipt.Id);
            }
            else
            {
                throw new Exception("This Receipt doesn´t exist");
            }
            return await _mapper.GetOneReceipt(receipt);
        }

        public async Task<List<ReceiptResponse>> GetAll()
        {
            var receipts = await _query.GetAll();
            return await _mapper.GetReceipts(receipts);
        }

        public async Task<ReceiptResponse> GetById(int Id)
        {
            var receipt = await _query.GetById(Id);
            return await _mapper.GetOneReceipt(receipt);
        }
    }
}
