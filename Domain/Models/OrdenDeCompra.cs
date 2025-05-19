using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrdenDeCompra
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProviderId { get; set; }
        public Proveedor Provider { get; set; }
        public float Amount { get; set; }
    }
}
