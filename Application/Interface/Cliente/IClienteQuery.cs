namespace Application.Interface.Cliente
{
    public interface IClienteQuery
    {
        Task<List<Domain.Models.Cliente>> GetAll();
        Task<Domain.Models.Cliente> GetById(int id);       
    }
}
