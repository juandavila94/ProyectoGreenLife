using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CapaDatos_GreenLife
{
    public class clsDatosUsuario
    {

        GreenlifeEntities bd = new GreenlifeEntities();



        public void InsertarUsuario(string usuario, string password, string nombre, int rol)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spInsertarUsuario(usuario, password, nombre, rol);
                bd.SaveChanges();
            }
        }

        public void EliminarUsuario(string usuario)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spEliminarUsuario(usuario);
                bd.SaveChanges();
            }
        }

        public void ModificarUsuario(int id, string usuario, string password, string nombre, int rol)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spModificarUsuario(id, usuario, password, nombre, rol);
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

        public object Login(string usuario, string password)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spLogin(usuario,  password).ToList();
                bd.SaveChanges();
                return courseList;
            }

        }
    }
}
