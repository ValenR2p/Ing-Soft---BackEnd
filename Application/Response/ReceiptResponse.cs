using Domain.Models;

namespace Application.Request
{
    public class ReceiptResponse
    {
        public int Id { get; set; }
        public int FactureId { get; set; }
        public Factura Facture { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int PaymentMethod { get; set; }
        public FormaCobranza Method { get; set; }
    }
}
