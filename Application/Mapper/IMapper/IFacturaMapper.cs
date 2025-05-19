using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IFacturaMapper
    {
        Task<List<FactureResponse>> GetFactures(List<Factura> factures);
        Task<FactureResponse> GetOneFacture(Factura facture);
    }
}
