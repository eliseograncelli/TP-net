using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LineaVenta
    {
        public int IdProducto { get; set; }
        //int IdPedido { get; set; }
        public int Cantidad { get; set; }

        public LineaVenta(ProductoBE p, int c)
        {
            IdProducto = p.IdProd;
            Cantidad = c;
        }

    }
}
