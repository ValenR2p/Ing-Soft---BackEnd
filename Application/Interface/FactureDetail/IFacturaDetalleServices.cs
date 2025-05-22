using Application.Request;
using Application.Response;

namespace Application.Interface.FactureDetail
{
    public interface IFacturaDetalleServices
    {
        Task<FactureDetailResponse> CreateFactureDetail(FactureDetailRequest request);
        Task<List<FactureDetailResponse>> GetAll();
        Task<FactureDetailResponse> GetById(int id);
    }
}
