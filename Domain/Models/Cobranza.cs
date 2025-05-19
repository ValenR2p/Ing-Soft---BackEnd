using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cobranza
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
