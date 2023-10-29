using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Venta
    {
        public int Id { get; set; }
        [ForeignKey("UsuarioBE")]
        public int IdCliente { get; set; }
        public DateTime fecha { get; set; }
        public float Monto { get; set; }
        public List<LineaVenta> Lineas { get; set; }
        public string Estado { get; set; }


        public Venta(UsuarioBE us)
        {
            IdCliente = us.Id;
            fecha = DateTime.Now;
            Estado = "Pendiente";
            Lineas = new List<LineaVenta> { };
        }

        public List<LineaVenta> MostrarLineas()
        {
            //return Lineas.ToList();
            return Lineas;
        }

        public void AgregarLinea(LineaVenta lv)
        {
            Lineas.Add(lv);
        }

        public void AgregarProductos(ProductoBE p, int cantidad)
        {
            LineaVenta lv = new LineaVenta(p, cantidad);
            Lineas.Add(lv);
        } 


    }
}
