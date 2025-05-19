using Application.Request;
using Application.Response;

namespace Application.Interface.Facture
{
    public interface IFacturaServices
    {
        Task<FactureResponse> CreateFacture(FactureRequest request);
        Task<FactureResponse> UpdateFacture(FactureRequest request, int FactureId);
        Task<List<FactureResponse>> GetAll();
        Task<FactureResponse> GetById(int id);
    }
}
