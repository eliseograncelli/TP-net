using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BusinessEntities;


namespace DataAccess
{
    public class UsuarioData
    {
        Conexion conexion;
        public UsuarioData()
        {
            conexion = new Conexion();
        }

        public string GuardarUsuario(UsuarioBE usuNuevo) // OK
        {
            return conexion.Pruebaconectar(
                "INSERT INTO Usuarios (DNI,Nombre,Apellido,Email,Password,Tipo,Estado) " +
                "VALUES ('" + usuNuevo.DNI + "','" + usuNuevo.Nombre + "', '" + usuNuevo.Apellido + "', '" + usuNuevo.Email + "','" + usuNuevo.Password + "', '" + usuNuevo.Tipo + "', '" + usuNuevo.Estado + "' );");
        }

        public string EliminarDeBD(UsuarioBE us)
        {
            return conexion.Pruebaconectar(
                "DELETE FROM Usuarios WHERE id = '" + us.Id + "'");
        } // OK

        public string Modificar(UsuarioBE usu)
        {
           return conexion.Pruebaconectar(
                "Update Usuarios Set nombre='"
                + usu.Nombre + "',dni='" + usu.DNI + "',email='" + usu.Email + "' ,apellido= '" + usu.Apellido + "',password='" + usu.Password + "', tipo= '" + usu.Tipo + "', estado= '" + usu.Estado + "' Where id =" + usu.Id);
           
        } // OK

        public DataSet MostrarUsuarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Usuarios");
            return conexion.EjecutarSentencia(sentencia);
        } // OK

        public UsuarioBE BuscarUsu(UsuarioBE usu)
        {
            SqlDataReader r;
            string cadena = "SELECT * FROM Usuarios WHERE email = '" + usu.Email + "' AND password = '" + usu.Password + "'";
            r = conexion.Ejecutador(cadena);

            if (r.Read())
            {
                UsuarioBE usuarioEncontrado = new UsuarioBE();
                usuarioEncontrado.Email = usu.Email;
                usuarioEncontrado.Password = usu.Password;
                usuarioEncontrado.Nombre = r["nombre"].ToString();
                usuarioEncontrado.Apellido = r["apellido"].ToString();
                usuarioEncontrado.Estado = r["estado"].ToString();
                usuarioEncontrado.Tipo = r["tipo"].ToString();
                usuarioEncontrado.DNI = (int)r["dni"];
                usuarioEncontrado.Id = (int)r["id"];
                return usuarioEncontrado;

            }
            else
            {
                return null;
            }
        }  // OK

        public UsuarioBE BuscarUsuPorId(UsuarioBE usu)
        {
            SqlDataReader r;
            string cadena = "SELECT * FROM Usuarios WHERE Id = '" + usu.Id + "'";
            r = conexion.Ejecutador(cadena);

            if (r.Read())
            {
                UsuarioBE usuarioEncontrado = new UsuarioBE();
                usuarioEncontrado.Email = r["Email"].ToString();
                usuarioEncontrado.Password = r["Password"].ToString();
                usuarioEncontrado.Nombre = r["nombre"].ToString();
                usuarioEncontrado.Apellido = r["apellido"].ToString();
                usuarioEncontrado.Estado = r["estado"].ToString();
                usuarioEncontrado.Tipo = r["tipo"].ToString();
                usuarioEncontrado.DNI = (int)r["dni"];
                usuarioEncontrado.Id = (int)r["id"];
                return usuarioEncontrado;

            }
            else
            {
                // Usuario no encontrado

                return null;
            }

        }

        public UsuarioBE GetCliente(Venta venta)
        {
            using(var dbContext = new AppDBContext())
            {
                return dbContext.Usuarios.Where(u => u.Id == venta.IdCliente).ToList().FirstOrDefault();
            }
        }
    }
}
