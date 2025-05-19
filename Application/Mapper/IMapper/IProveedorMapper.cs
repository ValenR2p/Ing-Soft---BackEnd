using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IProveedorMapper
    {
        Task<List<ProviderResponse>> GetProviders(List<Proveedor> providers);
        Task<ProviderResponse> GetOneProvider(Proveedor provider);
    }
}
