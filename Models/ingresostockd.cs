//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlasticosCerriDeposito.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ingresostockd
    {
        public int id { get; set; }
        public int idingreso { get; set; }
        public int idart { get; set; }
        public string codart { get; set; }
        public string art { get; set; }
        public int idposicion { get; set; }
        public int cantidad { get; set; }
    }
}
