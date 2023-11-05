using BusinessEntities;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   // internal class ProductoBL
   // {



        //public List<ProductoBE> MostrarProductos()
        //{
        //    foreach (ProductoBE p in ListaProductos)
        //}
    public class ProductoBL
    {
        public string Agregar(ProductoBE proNuevo)
        {
            ProductoData newProdData = new ProductoData();
            return newProdData.agregarProd(proNuevo);
            
        }

        public string Eliminar(int idProducto)
        {
            ProductoData newProdData = new ProductoData();
            return newProdData.eliminarProd(idProducto);
        }

        public string Modificar(ProductoBE ProdAEditar, int idProd)
        {
            ProductoData newProdData = new ProductoData();
            return newProdData.editarProd(ProdAEditar, idProd);
        }

        public List<ProductoBE> ObtenerProductos(int id)
        {
            ProductoData proD = new ProductoData();
            return proD.listar(id);
        }

        public List<ProductoBE> ObtenerProductos()
        {
            ProductoData proD = new ProductoData();
            return proD.ListarProductos();
        }

        public ProductoBE MostrarProducto(ProductoBE p)
        {
            ProductoData prod = new ProductoData();
            return prod.BuscarProd(p);
        }

        public static ProductoBE? buscarProducto(LineaVenta lV)
        {
            ProductoData pD = new ProductoData();
            return pD.BuscarProdXlinea(lV);
        }
    }
}
