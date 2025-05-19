using Application.Response;
using Domain.Models;

namespace Application.Mapper.IMapper
{
    public interface IClientMapper
    {
        Task<List<ClienteResponse>> GetClients(List<Cliente> clients);
        Task<ClienteResponse> GetOneClient(Cliente client);
    }
}
