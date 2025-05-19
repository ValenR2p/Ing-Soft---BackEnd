namespace Application.Request
{
    public class FactureRequest
    {
        public DateTime EmisionDate { get; set; }
        public int ClientId { get; set; }
        public float Amount { get; set; }
        public int PaymentMethod { get; set; }
    }
}
