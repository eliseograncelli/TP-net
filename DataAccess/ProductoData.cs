using BusinessEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductoData
    {
        public string agregarProd(ProductoBE nuevoProd)
        {
            using(var dbContext = new AppDBContext())
            {
                try
                {
                    dbContext.Producto.Add(nuevoProd);
                    dbContext.SaveChanges();
                    return "Producto agregado";
                }
                catch (Exception ex)  { return ex.Message; }
            }
        }

        public string editarProd(ProductoBE prodNuevo, int idProd)
        {
            using (var dbContext = new AppDBContext()) 
            {
                try 
                {
                    ProductoBE prodAModificar = dbContext.Producto.Find(idProd);
                    if (prodAModificar != null)
                    {
                        prodAModificar.Nombre = prodNuevo.Nombre;
                        prodAModificar.Marca = prodNuevo.Marca;
                        prodAModificar.Descripcion = prodNuevo.Descripcion;
                        prodAModificar.PrecioUnitario = prodNuevo.PrecioUnitario;
                        prodAModificar.PrecioX10 = prodNuevo.PrecioX10;
                        prodAModificar.PrecioMayorista = prodNuevo.PrecioMayorista;
                        prodAModificar.imagen = prodNuevo.imagen;
                        prodAModificar.stock = prodNuevo.stock;
                        dbContext.SaveChanges();
                        return "Producto modificado";
                    }
                    else return "Producto no encontrado";
                } 
                catch (Exception ex) { return ex.Message; }
            }
        }

        public string eliminarProd(int idProducto)
        {
            using (var dbContext = new AppDBContext()) 
            {
                try
                {
                    ProductoBE proEliminar = dbContext.Producto.FirstOrDefault(p => p.IdProd == idProducto);
                    dbContext.Producto.Remove(proEliminar);
                    dbContext.SaveChanges();
                    return "Producto eliminado";
                }
                catch (Exception ex) { return ex.Message; }
            }
        }

        public List<ProductoBE> listar(int id)
        {
            using (var dbContext = new AppDBContext())
            {
               return dbContext.Producto.Where(p => p.IdVendedor==id).ToList(); 
            }
        }

        public List<ProductoBE> ListarProductos()
        {
            using ( var dbContext = new AppDBContext())
            {
                return dbContext.Producto.ToList();
            }
        }

        public ProductoBE BuscarProd(ProductoBE prod)
        {
            using( var dbContext = new AppDBContext())
            {
                return dbContext.Producto.Where(p => p.IdProd == prod.IdProd).ToList().FirstOrDefault();
            }
        }
    }
}
