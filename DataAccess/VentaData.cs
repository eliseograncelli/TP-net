using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VentaData
    {
        public string AgregarVenta(Venta v)
        {
            try
            {
                using(var dbContext = new AppDBContext())
                {
                    dbContext.Ventas.Add(v);
                    dbContext.SaveChanges();
                    return "Compra confirmada";
                }
            }
            catch (Exception ex) { return ex.Message;}
        }

        public List<Venta> ListarCompras(UsuarioBE us)
        {
            try
            {
                using (var dbContext = new AppDBContext())
                {
                    return dbContext.Ventas.Where(v => v.IdCliente == us.Id).ToList();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
