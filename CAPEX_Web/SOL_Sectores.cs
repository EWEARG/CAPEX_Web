//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAPEX_Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOL_Sectores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOL_Sectores()
        {
            this.SOL_Proyectos = new HashSet<SOL_Proyectos>();
            this.SOL_Usuarios = new HashSet<SOL_Usuarios>();
        }
    
        public int SECTOR_ID { get; set; }
        public string SECTOR_NOMBRE { get; set; }
        public int AREA_ID { get; set; }
        public string SECTOR_STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOL_Proyectos> SOL_Proyectos { get; set; }
        public virtual SOL_Areas SOL_Areas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOL_Usuarios> SOL_Usuarios { get; set; }
    }
}
