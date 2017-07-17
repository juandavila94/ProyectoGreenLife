using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenLife
{
    static class Global
    {
        private static int idUsuario;
        private static int idCliente=0000000000;

        public static int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public static int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }
    }
}
