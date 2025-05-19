using Application.Interface.Provider;
using Application.Request;
using Application.Response;

namespace Application.UseCase
{
    internal class ProveedorServices : IProveedorServices
    {
        public Task<ProviderResponse> CreateProvider(ProviderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ProviderResponse> DeleteProvider(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProviderResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProviderResponse> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProviderResponse> UpdateProvider(ProviderRequest request, int ProviderId)
        {
            throw new NotImplementedException();
        }
    }
}
