namespace Application.Request
{
    public class FactureDetailRequest
    {
        public int FactureId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }
        public float TotalCost { get; set; }
    }
}
