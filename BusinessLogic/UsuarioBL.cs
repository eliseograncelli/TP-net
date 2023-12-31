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

        public string Agregar(UsuarioBE usuNuevo)
        {
            UsuarioData usuData = new UsuarioData();
            if (usuData.GuardarUsuario(usuNuevo) == "true")
            {
                return "Cuentra creada con exito";
            }
            else
            {
                return usuData.GuardarUsuario(usuNuevo);
            }
        } // OK

        public string Eliminar(UsuarioBE us)
        {
            UsuarioData usuarioData = new UsuarioData();
            return usuarioData.EliminarDeBD(us);
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

        public UsuarioBE BuscadorPorID(UsuarioBE us)
        {
            UsuarioData usu = new UsuarioData();
            return usu.BuscarUsuPorId(us);
        }

        public static UsuarioBE getCliente(Venta venta)
        {
            UsuarioData usuarioData=new UsuarioData();
            return usuarioData.GetCliente(venta);
        }
    }
}