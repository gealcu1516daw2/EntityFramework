//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkBBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class client
    {
        public client()
        {
            this.facturas = new HashSet<factura>();
        }
    
        public int id_client { get; set; }
        public string nom { get; set; }
        public string cognom1 { get; set; }
        public string cognom2 { get; set; }
        public string adresa { get; set; }
        public int codi_postal { get; set; }
        public string poblacio { get; set; }
        public string provincia { get; set; }
        public Nullable<int> telefon { get; set; }
        public Nullable<int> fax { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<factura> facturas { get; set; }
    }
}
