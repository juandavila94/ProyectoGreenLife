using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_GreenLife
{
    public class clsDatosDetalle
    {

        GreenlifeEntities bd = new GreenlifeEntities();
        public void InsertarDetalle(int idFactura, int idPlato, int cantidad, decimal precio)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spInsertarDetalle(idFactura, idPlato, cantidad, precio);
                bd.SaveChanges();
            }
        }
    }
}
