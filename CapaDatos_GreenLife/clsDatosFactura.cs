﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_GreenLife
{
    public class clsDatosFactura
    {
        GreenlifeEntities bd = new GreenlifeEntities();
        public void InsertarFactura(int idUsuario, int idCliente, DateTime fecha, string metodoDePago, decimal subtotal, decimal iva, decimal total )
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spInsertarFactura( idUsuario,  idCliente,  fecha,  metodoDePago,  subtotal,  iva,  total,true);
                bd.SaveChanges();

            }
        }


        public void AnularFactura(int idFactura)
        {
            using (var bd = new GreenlifeEntities())
            {
                var courseList = bd.spAnularFactura(idFactura);
                bd.SaveChanges();
            }
        }

        public object ConsultarFacturasDia(DateTime dia)
        {
            return bd.spConsultarFacturasDia(dia).ToList();
        }

        public object ConsultarFacturacionDiaria(DateTime dia)
        {
            return bd.spConsultarFacturacionDiaria(dia).ToList();
        }

        public object ConsultarFacturasPorCliente(int id)
        {
            return bd.spConsultarFacturasPorCliente(id).ToList();
        }

        public object ConsultarFacturasPorUsuario(int id)
        {
            return bd.spConsultarFacturasPorUsuario(id).ToList();
        }

        public int ConsultarUltimoIDFactura()
        {
            List<int> lista = new List<int>();

            foreach (int i in bd.spConsultarUltimoIDFactura().ToList())
            {
                lista.Add(i);
            }
            return lista[0];
        }
    }
}
