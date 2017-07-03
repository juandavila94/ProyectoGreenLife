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

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
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



        //ingreso al sistema por login

        public object login(string userName, string password)
        {
            
            return objDatosUsuario.Login(userName, password);
                    
        }

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
