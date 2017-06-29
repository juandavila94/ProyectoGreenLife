using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos_GreenLife;

namespace CapaNegocio_GreenLife
{
    public class clsPlato
    {
        clsDatosPlato objDatosPlato = new clsDatosPlato();
        private int idPlato;

        
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        

        public int IdPlato
        {
            get { return idPlato; }
            set { idPlato = value; }
        }

        private byte[] foto;
        public byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        public void insertarPlato(string name, decimal prize, string type, byte[] photo)
        {
            try
            {
                Nombre = name;
                Precio = prize;
                Tipo = type;
                Foto = photo;

                objDatosPlato.InsertarPlato(Nombre, Precio, Tipo, Foto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarPlato(int id)
        {
            try
            {
                IdPlato = id;

                objDatosPlato.EliminarPlato(IdPlato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarPlato(int id, string name, decimal prize, string type)
        {
            try
            {
                IdPlato = id;
                Nombre = name;
                Precio = prize;
                Tipo = type;
                

                objDatosPlato.ModificarPlato(IdPlato, Nombre, Precio, Tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarPlatos()
        {
            try
            {
                return objDatosPlato.ConsultarPlatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarPlatosPorNombre(string name)
        {
            try
            {
                Nombre = name;
                return objDatosPlato.ConsultarPlatosPorNombre(Nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object consultarPlatosPorTipo(string type)
        {
            try
            {
                Tipo = type;
                return objDatosPlato.ConsultarPlatosPorNombre(Tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
