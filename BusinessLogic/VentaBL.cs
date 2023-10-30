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
        public string AgregarVenta(Venta v)
        {
            VentaData venta = new VentaData();
            return venta.AgregarVenta(v);
        } 
    }
}
