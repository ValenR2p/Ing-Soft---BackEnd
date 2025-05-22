using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    public class DetalleFacturaMapper : IDetalleFacturaMapper
    {
        public Task<List<FactureDetailResponse>> GetFactureDetails(List<DetalleFactura> factureDetails)
        {
            List<FactureDetailResponse> responses = new List<FactureDetailResponse>();
            foreach (var factureDetail in factureDetails)
            {
                var response = new FactureDetailResponse
                {
                    Id = factureDetail.Id,

                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<FactureDetailResponse> GetOneFactureDetail(DetalleFactura factureDetail)
        {
            var response = new FactureDetailResponse
            {
                Id = factureDetail.Id,
            };

            return Task.FromResult(response);
        }
    }
}
