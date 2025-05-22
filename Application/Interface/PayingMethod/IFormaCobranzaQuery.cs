using Domain.Models;

namespace Application.Interface.PayingMethod
{
    public interface IFormaCobranzaQuery
    {
        Task<List<FormaCobranza>> GetAll();
        Task<FormaCobranza> GetById(int id);       
    }
}
