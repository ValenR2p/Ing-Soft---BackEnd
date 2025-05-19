using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class CobranzaMapper : ICobranzaMapper
    {
        public Task<List<ReceiptResponse>> GetReceipts(List<Cobranza> receipts)
        {
            List<ReceiptResponse> responses = new List<ReceiptResponse>();
            foreach (var receipt in receipts)
            {
                var response = new ReceiptResponse
                {
                    Id = receipt.Id,
                    FactureId = receipt.FactureId,
                    Facture = receipt.Facture,
                    Date = receipt.Date,
                    Amount = receipt.Amount,
                    PaymentMethod = receipt.PaymentMethod,
                    Method = receipt.Method,
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<ReceiptResponse> GetOneReceipt(Cobranza receipt)
        {
            var response = new ReceiptResponse
            {
                Id = receipt.Id,
                FactureId = receipt.FactureId,
                Facture = //_x.GetOneFacture(receipt.PaymentMethod);
                receipt.Facture,
                Date = receipt.Date,
                Amount = receipt.Amount,
                PaymentMethod = receipt.PaymentMethod,
                Method = //_x.GetOnePaymentMethod(receipt.PaymentMethod);
                receipt.Method,
            };
            return Task.FromResult(response);
        }
    }
}
