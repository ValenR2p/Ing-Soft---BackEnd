using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DetalleOrden
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrdenDeCompra Order { get; set; }
        public int ProductId { get; set; }
        public Producto Product { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }

    }
}
