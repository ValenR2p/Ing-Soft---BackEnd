using Domain.Models;

namespace Application.Interface.FactureDetail
{
    public interface IFacturaDetalleCommand
    {
        Task InsertFactureDetail(DetalleFactura factureDetail);
    }
}
