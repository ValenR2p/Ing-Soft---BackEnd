using Application.Request;
using Application.Response;

namespace Application.Interface.Cliente
{
    public interface IClienteServices
    {
        Task<ClienteResponse> CreateClient(ClientRequest request);
        Task<ClienteResponse> UpdateClient(ClientRequest request, int ClientId);
        Task<ClienteResponse> DeleteClient(int id);
        Task<List<ClienteResponse>> GetAll();
        Task<ClienteResponse> GetById(int id);
    }
}
