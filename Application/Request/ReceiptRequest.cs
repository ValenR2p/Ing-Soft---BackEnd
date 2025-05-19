namespace Application.Request
{
    public class ReceiptRequest
    {
        public int FactureId { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int PaymentMethod { get; set; }
    }
}
