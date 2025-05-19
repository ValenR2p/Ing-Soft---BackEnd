using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    public class FacturaMapper : IFacturaMapper
    {
        public Task<List<FactureResponse>> GetFactures(List<Factura> factures)
        {
            List<FactureResponse> responses = new List<FactureResponse>();
            foreach (var facture in factures)
            {
                var response = new FactureResponse
                {
                    Id = facture.Id,
                    Amount = facture.Amount,
                    PaymentMethod = facture.PaymentMethod,
                    Method = facture.Method,
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<FactureResponse> GetOneFacture(Factura facture)
        {         
            var response = new FactureResponse
            {
                Id = facture.Id,
                Amount = facture.Amount,
                PaymentMethod = facture.PaymentMethod,
                Method = facture.Method,
            };
            return Task.FromResult(response);
        }
    }
}
