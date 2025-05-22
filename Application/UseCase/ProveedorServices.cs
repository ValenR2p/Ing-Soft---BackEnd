using Application.Interface.Provider;
using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Domain.Models;

namespace Application.UseCase
{
    public class ProveedorServices : IProveedorServices
    {
        private readonly IProveedorQuery _query;
        private readonly IProveedorCommand _command;
        private readonly IProveedorMapper _mapper;

        public ProveedorServices(IProveedorQuery query, IProveedorCommand command, IProveedorMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }
        public async Task<ProviderResponse> CreateProvider(ProviderRequest request)
        {
            var newProvider = new Proveedor
            {
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone,
            };

            await _command.InsertProvider(newProvider);
            return await _mapper.GetOneProvider(newProvider);
        }

        public async Task<ProviderResponse> UpdateProvider(ProviderRequest request, int ProviderId)
        {
            var provider = await _query.GetById(ProviderId);
            if (provider != null)
            {
                provider.Name = request.Name;
                provider.Address = request.Address;
                provider.Email = request.Email;
                provider.Phone = request.Phone;
            }
            else 
            {
                throw new Exception("This provider doesn´t exist");
            }

            await _command.UpdateProvider(provider);
            return await _mapper.GetOneProvider(provider);
        }

        public async Task<ProviderResponse> DeleteProvider(int Id)
        {
            var provider = await _query.GetById(Id);
            if (provider != null)
            {
                _command.DeleteProvider(Id);
            }
            else
            {
                throw new Exception("This provider doesn´t exist");
            }

            return await _mapper.GetOneProvider(provider);
        }

        public async Task<List<ProviderResponse>> GetAll()
        {
            var providers = await _query.GetAll();
            return await _mapper.GetProviders(providers);
        }

        public async Task<ProviderResponse> GetById(int Id)
        {
            var provider = await _query.GetById(Id);
            return await _mapper.GetOneProvider(provider);
        }

        
    }
}
