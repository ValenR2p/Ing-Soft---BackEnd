using Application.Request;
using Application.Response;

namespace Application.Interface.Provider
{
    public interface IProveedorServices
    {
        Task<ProviderResponse> CreateProvider(ProviderRequest request);
        Task<ProviderResponse> UpdateProvider(ProviderRequest request, int ProviderId);
        Task<ProviderResponse> DeleteProvider(int id);
        Task<List<ProviderResponse>> GetAll();
        Task<ProviderResponse> GetById(int id);
    }
}
