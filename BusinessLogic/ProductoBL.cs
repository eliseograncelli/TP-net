using BusinessEntities;
<<<<<<< HEAD
=======
using DataAccess;
using Microsoft.EntityFrameworkCore;
>>>>>>> e71980d82a7f8a63a0abfdc44239699255324571
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
<<<<<<< HEAD
    internal class ProductoBL
    {



        //public List<ProductoBE> MostrarProductos()
        //{
        //    foreach (ProductoBE p in ListaProductos)
        //}
=======
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
>>>>>>> e71980d82a7f8a63a0abfdc44239699255324571
    }
}
