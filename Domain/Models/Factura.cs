using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Factura
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
