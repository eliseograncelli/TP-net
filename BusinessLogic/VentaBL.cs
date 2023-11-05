using BusinessEntities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class VentaBL
    {
        public static Venta getVenta(LineaVenta lV)
        {
            VentaData v = new VentaData();
            return v.GetVenta(lV);
        }

        public string AgregarVenta(Venta v)
        {
            VentaData venta = new VentaData();
            return venta.AgregarVenta(v);
        } 

        public List<Venta> ListarCompras(UsuarioBE us)
        {
            VentaData v = new VentaData();
            return v.ListarCompras(us);
        }

        public List<LineaVenta> ListarLineas(UsuarioBE usuario)
        {
            VentaData datos = new VentaData();
            return datos.ListarLineas(usuario);
        }
    }
}
