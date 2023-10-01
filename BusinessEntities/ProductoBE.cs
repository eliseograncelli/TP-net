using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ProductoBE
    {
        [Key]
        public int IdProd { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
           
        [ForeignKey("UsuarioBE")]
        public int IdVendedor { get; set; }

        public float PrecioUnitario { get; set; }
        public float PrecioX10 { get; set; }
        public float PrecioMayorista { get; set; }
        public string Descripcion { get; set; }
        public byte[]? imagen { get; set; }
        public int stock { get; set; }  




        public ProductoBE(string Nombre, string Marca, string Descripcion, float PrecioUnitario, float PrecioX10, float PrecioMayorista, int IdVendedor, byte[] imagen, int stock)
        {
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.Descripcion = Descripcion;
            this.PrecioUnitario = PrecioUnitario;
            this.PrecioX10 = PrecioX10;
            this.PrecioMayorista = PrecioMayorista;
            this.IdVendedor = IdVendedor;
            this.imagen = imagen;
            this.stock = stock;
        }

    }


}
