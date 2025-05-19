namespace Application.Request
{
    public class OrderRequest
    {
        public DateTime Date { get; set; }
        public int ProviderId { get; set; }
        public float Amount { get; set; }
    }
}
