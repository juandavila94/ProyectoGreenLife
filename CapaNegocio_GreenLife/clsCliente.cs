using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos_GreenLife;

namespace CapaNegocio_GreenLife
{
    public class clsCliente
    {
        clsDatosCliente objDatosCliente = new clsDatosCliente();

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

        public void insertarCliente(string ced, string nom, string dir, string telf)
        {
            try
            {
                Cedula = ced;
                Nombre = nom;
                Direccion = dir;
                Telefono = telf;

                objDatosCliente.InsertarCliente(Cedula,Nombre,Direccion,Telefono);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void elimininarCliente(string ced)
        {
            try
            {
                Cedula = ced; 
                objDatosCliente.EliminarCliente(Cedula);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarCliente(int id,string ced, string nom, string dir, string telf)
        {
            try
            {
                IdCliente = id;
                Cedula = ced;
                Nombre = nom;
                Direccion = dir;
                Telefono = telf;

                objDatosCliente.ModificarCliente(IdCliente, Cedula, Nombre, Direccion, Telefono);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarClientes()
        {
            try
            {
                return objDatosCliente.ConsultarClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarClientesPorNombre(string name)
        {
            try
            {
                Nombre = name;
                return objDatosCliente.ConsultarClientesPorNombre(Nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarClientesPorCedula(string ced)
        {
            try
            {
                Cedula = ced;
                return objDatosCliente.ConsultarClientesPorCedula(Cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
