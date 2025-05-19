using Domain.Models;

namespace Application.Interface.Facture
{
    public interface IFacturaQuery
    {
        Task<List<Factura>> GetAll();
        Task<Factura> GetById(int id);       
    }
}
