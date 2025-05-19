using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    internal class ProveedorMapper : IProveedorMapper
    {
        public Task<ProviderResponse> GetOneProvider(Proveedor provider)
        {
            var response = new ProviderResponse
            {
                Id = provider.Id,
                Name = provider.Name,
            };

            return Task.FromResult(response);
        }

        public Task<List<ProviderResponse>> GetProviders(List<Proveedor> providers)
        {
            List<ProviderResponse> responses = new List<ProviderResponse>();
            foreach (var provider in providers)
            {
                var response = new ProviderResponse
                {
                    Id = provider.Id,
                    Name = provider.Name,
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }
    }
}
