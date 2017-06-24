using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio_GreenLife
{
    public class clsCliente
    {
        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
