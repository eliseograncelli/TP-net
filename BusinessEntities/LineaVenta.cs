using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LineaVenta
    {
        [Key]
        public int IdLinea { get; set; }
        [ForeignKey("ProductoBE")]
        public int IdProd { get; set; }
        [ForeignKey("Venta")]
        public int VentaId { get; set; }
        public int Cantidad { get; set; }

        public LineaVenta()
        {}

        public LineaVenta(ProductoBE p, int c)
        {
            IdProd = p.IdProd;
            Cantidad = c;
        }

    }
}
