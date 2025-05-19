using Application.Interface.Cliente;
using Application.Mapper.IMapper;
using Application.Request;
using Application.Response;
using Domain.Models;

namespace Application.UseCase
{
    public class ClientServices : IClienteServices
    {
        private readonly IClienteQuery _query;
        private readonly IClienteCommand _command;
        private readonly IClientMapper _mapper;
        public ClientServices(IClienteQuery query, IClienteCommand command, IClientMapper mapper)
        {
            _query = query;
            _command = command;
            _mapper = mapper;
        }

        public async Task<ClienteResponse> CreateClient(ClientRequest request)
        {
            var newClient = new Cliente
            {
                Name = request.Name,
                Surname = request.Surname,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone,
                DNI = request.DNI,
            };

            await _command.InsertClient(newClient);
            return await _mapper.GetOneClient(newClient);
        }
        public async Task<ClienteResponse> UpdateClient(ClientRequest request, int ClientId)
        {
            var client = await _query.GetById(ClientId);
            if (client != null)
            {
                client.Name = request.Name;
                client.Surname = request.Surname;
                client.Address = request.Address;
                client.Phone = request.Phone;
                client.Email = request.Email;
            }
            else
            {
                throw new Exception("This client doesn´t exist");
            }
            await _command.UpdateClient(client);
            return await _mapper.GetOneClient(client);
        }

        public async Task<ClienteResponse> DeleteClient(int Id)
        {
            var client = await _query.GetById(Id);
            if (client != null)
            {
                await _command.DeleteClient(client.Id);
            }
            else{
                throw new Exception("This client doesn´t exist");
            }
            return await _mapper.GetOneClient(client);
        }

        public async Task<List<ClienteResponse>> GetAll()
        {
            var clients = await _query.GetAll();
            return await _mapper.GetClients(clients);
        }

        public async Task<ClienteResponse> GetById(int Id)
        {
            var client = await _query.GetById(Id);
            return await _mapper.GetOneClient(client);
        }

        
    }
}
