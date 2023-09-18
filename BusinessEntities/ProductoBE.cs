using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProductoBE
    {
        private int idProd { get; set; }
        private string nombre { get; set; }
        private string marca { get; set; }
        private string descripcion { get; set; }
        private float[] precios { get; set; }

        ProductoBE(string p1, string p2, string p3, float[] p4) {
            this.nombre = p1;
            this.marca = p2;
            this.descripcion = p3;
            precios = p4; 
        }

    }
}
