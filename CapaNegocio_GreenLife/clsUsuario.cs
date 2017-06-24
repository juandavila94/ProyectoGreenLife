using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio_GreenLife
{
    public class clsUsuario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string usuario;

        public string Usuario1
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


    }
}
