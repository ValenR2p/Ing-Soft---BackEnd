using Application.Mapper.IMapper;
using Application.Response;
using Domain.Models;

namespace Application.Mapper
{
    public class ClientMapper : IClientMapper
    {
        public Task<List<ClienteResponse>> GetClients(List<Cliente> clients)
        {
            List<ClienteResponse> responses = new List<ClienteResponse>();
            foreach (var client in clients)
            {
                var response = new ClienteResponse
                {
                    Id = client.Id,
                    Name = client.Name,
                    Surname = client.Surname,
                    DNI = client.DNI,
                };
                responses.Add(response);
            }
            return Task.FromResult(responses);
        }

        public Task<ClienteResponse> GetOneClient(Cliente client)
        {
            var response = new ClienteResponse
            {
                Id = client.Id,
                Name = client.Name,
                Surname = client.Surname,
                DNI = client.DNI,
            };
            return Task.FromResult(response);
        }
    }
}
