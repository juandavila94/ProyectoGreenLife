using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_GreenLife
{
    public class clsDatosCliente
    {

        GreenlifeEntities bd = new GreenlifeEntities();
        public void InsertarCliente(string cedula, string nombre, string direccion, string telefono)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spInsertarCliente(cedula,  nombre,  direccion,  telefono);
                bd.SaveChanges();
            }
        }

        public void EliminarCliente(string cedula)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spEliminarCliente(cedula);
                bd.SaveChanges();
            }
        }

        public void ModificarCliente(int id,string cedula, string nombre, string direccion, string telefono)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spModificarCliente(id, cedula,  nombre,  direccion,  telefono);
                bd.SaveChanges();
            }
        }

        public object ConsultarUsuarios()
        {
            return bd.spConsultarUsuarios().ToList();
        }

        public object ConsultarUsuariosPorNombre(string nombre)
        {
            return bd.spConsultarUsuarioPorNombre(nombre).ToList();
        }
    }
}
