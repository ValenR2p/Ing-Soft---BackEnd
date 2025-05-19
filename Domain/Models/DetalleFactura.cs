using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FactureId { get; set; }
        public Factura Facture { get; set; }
        public int ProductId{ get; set; }
        public Producto Product { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }
        public float TotalCost { get; set; }
    }
}
