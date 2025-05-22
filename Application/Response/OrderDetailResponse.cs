using Domain.Models;

namespace Application.Response
{
    public class OrderDetailResponse
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrdenDeCompra Order { get; set; }
        public int ProductId { get; set; }
        public Producto Product { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }
    }
}
