﻿using System.Data;
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

        public void Agregar(UsuarioBE usuNuevo)
        {
            UsuarioData usuData = new UsuarioData();
            if (usuData.GuardarUsuario(usuNuevo) == "true")
            {
                // MessageBox.Show("USUARIO {0} CREADO EXITOSAMENTE", usuNuevo.Nombre);
            }
            else
            {
                // MessageBox.Show("ERROR AL GUARDAR EMPLEADO " +usuData.GuardarUsuario(usuNuevo));
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

        public int Modificar(int id, int dni, string nombre, string Apellido, string email, string password, string tipo, string estado)
        {
            int nuevoDNI = dni;
            string nuevoNombre = nombre;
            string nuevoApe = Apellido;
            string nuevoEmail = email;
            string nuevaPas = password;
            string nuevoTipo = tipo;
            string nuevoEstado = estado;

            UsuarioBE usu = new UsuarioBE(nuevoDNI, nuevoNombre, nuevoApe, nuevoEmail, null, nuevaPas, nuevoTipo, nuevoEstado);

            UsuarioData usuData = new UsuarioData();
            if (usuData.Modificar(usu) == 1)
            {
                // MessageBox.Show("USUARIO MODIFICADO CON EXITO");
            }
            else
            {
                //  MessageBox.Show("NO SE PUDO MODIFICAR EL USUARIO");
            }

            return 1;
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