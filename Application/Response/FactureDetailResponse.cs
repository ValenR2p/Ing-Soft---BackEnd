using Domain.Models;

namespace Application.Response
{
    public class FactureDetailResponse
    {
        public int Id { get; set; }
        public int FactureId { get; set; }
        public Factura Facture { get; set; }
        public int ProductId { get; set; }
        public Producto Product { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }
        public float TotalCost { get; set; }
    }
}
