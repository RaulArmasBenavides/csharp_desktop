//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appcongreso.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipo()
        {
            this.listaequipos = new HashSet<listaequipos>();
        }
    
        public int idEquipo { get; set; }
        public string Nombre { get; set; }
        public string SO { get; set; }
        public string Procesador { get; set; }
        public string RAM { get; set; }
        public string TarjetaMadre { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<listaequipos> listaequipos { get; set; }
    }
}
