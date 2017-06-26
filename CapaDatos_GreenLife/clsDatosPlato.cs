using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_GreenLife
{
    public class clsDatosPlato
    {
        GreenlifeEntities bd = new GreenlifeEntities();
        public void InsertarPlato(string nombre, decimal precio, string tipo, byte[] foto)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spInsertarPlato(nombre, precio, tipo, foto);
                bd.SaveChanges();
            }
        }

        public void EliminarPlato(int id)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spEliminarPlato(id);
                bd.SaveChanges();
            }
        }

        public void ModificarPlato(int id, string nombre, decimal precio, string tipo)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spModificarPlato(id,  nombre, precio, tipo);
                bd.SaveChanges();
            }
        }

        public object ConsultarPlatos()
        {
            return bd.spConsultarPlatos().ToList();
        }

        public object ConsultarPlatosPorNombre(string nombre)
        {
            return bd.spConsultarPlatosPorNombre(nombre).ToList();
        }

        public object ConsultarPlatosPorTipo(string tipo)
        {
            return bd.spConsultarPlatosPorTipo(tipo).ToList();
        }
    }
}
