using Domain.Models;

namespace Application.Response
{
    public class OrderResponse
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProviderId { get; set; }
        public Proveedor Provider { get; set; }
        public float Amount { get; set; }
    }
}
