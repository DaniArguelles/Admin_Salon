//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicios()
        {
            this.citas = new HashSet<citas>();
        }
    
        public int Id { get; set; }
        public string Servicio { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<System.TimeSpan> duracion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<citas> citas { get; set; }
    }
}
