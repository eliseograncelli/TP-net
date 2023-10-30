using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UsuarioBE")]
        public int IdCliente { get; set; }
        public DateTime fecha { get; set; }
        public float Monto { get; set; }
        public List<LineaVenta> Lineas { get; set; }
        public string Estado { get; set; }
        [ForeignKey("IdCliente")]
        public UsuarioBE Cliente { get; set; }

        public Venta() { }

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
            return Lineas.ToList();
        }

        /*public void AgregarLinea(LineaVenta lv)
        {
            Lineas.Add(lv);
        } */

        public void AgregarProductos(ProductoBE p, int cantidad)
        {
            bool band = false;
            foreach(LineaVenta misLineas in Lineas)
            {
                if(misLineas.IdProd == p.IdProd)
                {
                    misLineas.Cantidad = cantidad;
                    band = true;
                }
            }
            if(band==false)
            {
                LineaVenta lv = new LineaVenta(p, cantidad, this);
                Lineas.Add(lv);
            }
        } 


    }
}
