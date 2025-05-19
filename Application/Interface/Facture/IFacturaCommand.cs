using Domain.Models;

namespace Application.Interface.Facture
{
    public interface IFacturaCommand
    {
        Task InsertFacture(Factura facture);
        Task UpdateFacture(Factura facture);
    }
}
