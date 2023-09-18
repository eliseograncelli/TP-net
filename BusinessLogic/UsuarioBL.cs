using System.Data;
using DataAccess;
using BusinessEntities;

namespace BusinessLogic
{
    public class UsuarioBL
    {
        Conexion conexion;
        public UsuarioBL()
        {
            conexion = new Conexion();
        }

        public string Agregar(UsuarioBE usuNuevo)
        {
            UsuarioData usuData = new UsuarioData();
            if (usuData.GuardarUsuario(usuNuevo) == "true")
            {
                return usuNuevo.Nombre;
            }
            else
            {
                return usuData.GuardarUsuario(usuNuevo);
            }
        } // OK

        public void Eliminar(int id)
        {
            // ¿NECESARIO RECUPERAR EL OBJETO COMPLETO?
            UsuarioData usuarioData = new UsuarioData();
            if (usuarioData.EliminarDeBD(id) == 1)
            {
                // MessageBox.Show("USUARIO ELIMINADO CON EXITO");
            }
            else
            {
                // MessageBox.Show("ERROR AL ELIMINAR USUARIO");
            }
        } // OK

        public string Modificar(UsuarioBE usu)
        {
            UsuarioData usuData = new UsuarioData();

            return usuData.Modificar(usu);

        } // OK


        public DataSet Listar()
        {
            UsuarioData usu = new UsuarioData();
            return usu.MostrarUsuarios();
        } // OK


        public UsuarioBE Buscador(UsuarioBE usuario)   // OK
        {
            
            UsuarioData usu = new UsuarioData();

            return usu.BuscarUsu(usuario);
        }


    }
}