namespace Application.Interface.Cliente
{
    public interface IClienteCommand
    {
        Task InsertClient(Domain.Models.Cliente client);
        Task UpdateClient(Domain.Models.Cliente client);
        Task DeleteClient(int id);
    }
}
