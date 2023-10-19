using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Venta
    {
        int Id { get; set; }
        int IdCliente { get; set; }
        DateTime fecha { get; set; }
        float Monto { get; set; }
        public List<LineaVenta> Lineas { get; set; }
        string Estado { get; set; }

        public Venta(UsuarioBE us, List<LineaVenta> misLineas)
        {
            fecha = DateTime.Now;
            IdCliente = us.Id;
            Lineas = misLineas;
            Estado = "Pendiente";

        }

        public List<LineaVenta> MostrarLineas()
        {
            return Lineas.ToList();
        }

       /* public void AgregarProductos(ProductoBE p, int cantidad)
        {
            LineaVenta lv = new LineaVenta(p, cantidad);
            Lineas.Add(lv);
        } */
    }
}
