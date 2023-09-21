using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace BusinessEntities
{
    public class UsuarioBE
    {
        [Key]
        public int Id { set; get; }
        public int DNI { set; get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }


        public byte[]? Foto { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }


        public UsuarioBE()
        {
            Tipo = "Cliente";
            Estado = "Inactivo";
        }

        public UsuarioBE(int dni, string nombre, string apellido, string email, byte[] foto, string password, string tipo, string estado)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Password = password;
            this.Foto = foto;
            this.Tipo = tipo;
            this.Estado = estado;
        }

        public UsuarioBE(int dni, string nombre, string apellido, string email, byte[] foto, string password, string tipo)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Password = password;
            this.Foto = foto;
            if (tipo == null)
            {
                this.Tipo = "Cliente";
            }
            else
            {
                this.Tipo = tipo;
            }
            this.Estado = "Inactivo";
        }

        public UsuarioBE(int id, int dNI, string nombre, string apellido, string email, byte[] foto, string password, string tipo, string estado)
        {
            Id = id;
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            Foto = foto;
            Tipo = tipo;
            Estado = estado;
        }

        public UsuarioBE(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
