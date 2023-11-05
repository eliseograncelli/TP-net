using BusinessEntities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public Venta GetVenta(LineaVenta lV)
        {
            using( var dbContext = new AppDBContext())
            {
                return dbContext.Ventas.Where(v => v.Id == lV.VentaId).ToList().FirstOrDefault();
            }
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

        public List<LineaVenta> ListarLineas(UsuarioBE usuario)
        {
            using (var dbContext = new AppDBContext())
            {
                Conexion conexion = new Conexion();
                SqlDataReader r;
                List<LineaVenta> totalLineas = new List<LineaVenta>();
                string cadena = "Select * From LineaVenta";
                r = conexion.Ejecutador(cadena);
                while (r.Read())
                {
                    LineaVenta lv = new LineaVenta();
                    lv.IdLinea = int.Parse(r["IdLinea"].ToString());
                    lv.IdProd = int.Parse(r["IdProd"].ToString());
                    lv.VentaId = int.Parse(r["VentaId"].ToString());
                    lv.Cantidad = int.Parse(r["Cantidad"].ToString());
                    totalLineas.Add(lv);
                }
                var productos = dbContext.Producto.Where(p => p.IdVendedor == usuario.Id).ToList();
                List<LineaVenta> lineas = new List<LineaVenta>();
                foreach (LineaVenta lv in totalLineas)
                {
                    var producto = dbContext.Producto.Where(p => p.IdProd == lv.IdProd).FirstOrDefault();
                    if (productos.Contains(producto))
                    {
                        lineas.Add(lv);
                    }
                }
                return lineas;
            }
        }
    }
}
