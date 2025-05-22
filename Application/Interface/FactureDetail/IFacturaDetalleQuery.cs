using Domain.Models;

namespace Application.Interface.FactureDetail
{
    public interface IFacturaDetalleQuery
    {
        Task<List<DetalleFactura>> GetAll();
        Task<DetalleFactura> GetById(int id);       
    }
}
