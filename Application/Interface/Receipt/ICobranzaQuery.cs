using Domain.Models;

namespace Application.Interface.Receipt
{
    public interface ICobranzaQuery
    {
        Task<List<Cobranza>> GetAll();
        Task<Cobranza> GetById(int id);       
    }
}
