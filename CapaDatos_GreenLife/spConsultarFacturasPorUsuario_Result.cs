//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos_GreenLife
{
    using System;
    
    public partial class spConsultarFacturasPorUsuario_Result
    {
        public int idFactura { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public int idCliente { get; set; }
        public System.DateTime fecha { get; set; }
        public string metodoDePago { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
    }
}
