using Domain.Models;

namespace Application.Response
{
    public class FactureResponse
    {
        public int Id { get; set; }
        public DateTime EmisionDate { get; set; }
        public int ClientId { get; set; }
        public Cliente Client { get; set; }
        public float Amount { get; set; }
        public int PaymentMethod { get; set; }
        public FormaCobranza Method { get; set; }
    }
}
