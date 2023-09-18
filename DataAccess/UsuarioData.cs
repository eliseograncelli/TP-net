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
                "INSERT INTO Usuario (dni,nombre,apellido,email,password,tipo,estado) " +
                "VALUES ('" + usuNuevo.DNI + "','" + usuNuevo.Nombre + "', '" + usuNuevo.Apellido + "', '" + usuNuevo.Email + "','" + usuNuevo.Password + "', '" + usuNuevo.Tipo + "', '" + usuNuevo.Estado + "' );");
        }

        public int EliminarDeBD(int id)
        {
            conexion.Pruebaconectar(
                "DELETE FROM Empleado WHERE id = '" + id + "'");
            return 1;
        } // OK

        public string Modificar(UsuarioBE usu)
        {
           return conexion.Pruebaconectar(
                "Update Usuario Set nombre='"
                + usu.Nombre + "',dni='" + usu.DNI + "',email='" + usu.Email + "' ,apellido= '" + usu.Apellido + "',password='" + usu.Password + "', tipo= '" + usu.Tipo + "', estado= '" + usu.Estado + "' Where id =" + usu.Id);
           
        } // OK

        public DataSet MostrarUsuarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Usuario");
            return conexion.EjecutarSentencia(sentencia);
        } // OK

        public UsuarioBE BuscarUsu(UsuarioBE usu)
        {
            SqlDataReader r;
            //  string cadena = "SELECT* FROM Usuario WHERE email = 'juan@gmail.co' AND password = 'eee'";
            string cadena = "SELECT * FROM Usuario WHERE email = '" + usu.Email + "' AND password = '" + usu.Password + "'";
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
                // Usuario no encontrado

                return null;
            }
        }  // OK
    }
}
