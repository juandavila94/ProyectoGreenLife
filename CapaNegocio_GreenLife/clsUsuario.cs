using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CapaDatos_GreenLife;

namespace CapaNegocio_GreenLife
{

    public class clsUsuario
    {
        clsDatosUsuario objDatosUsuario = new clsDatosUsuario();

        private int idUsuario;

        
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int rol;

        public int Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        //ingreso al sistema por login
        /*
        public int ingresoPorUsuario(string userName, string password)
        {
            Usuario = userName;
            Password = password;
            int rol = 0;

            try
            {
                rol = objDatosUsuario.ingresoPorUsuario(Usuario, Password);
                return rol;
            }
            catch (Exception ex)
            {
                return rol;
            }
        }*/

        public void insertarUsuario(string userName, string password, string name, int role)
        {
            try
            {
                Usuario = userName;
                Password = password;
                Nombre = name;
                Rol = role;

                objDatosUsuario.InsertarUsuario(Usuario, Password, Nombre, Rol);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void elimininarUsuario(string user)
        {
            try
            {
                Usuario = user;
                objDatosUsuario.EliminarUsuario(Usuario);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarUsuario(int id, string userName, string password, string name, int role)
        {
            try
            {
                IdUsuario = id;
                Usuario = userName;
                Password = password;
                Nombre = name;
                Rol = role;

                objDatosUsuario.ModificarUsuario(IdUsuario, Nombre, Password, Nombre, Rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarUsuarios()
        {
            try
            {
                return objDatosUsuario.ConsultarUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarUsuariosPorNombre(string name)
        {
            try
            {
                Nombre = name;
                return objDatosUsuario.ConsultarUsuariosPorNombre(Nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
