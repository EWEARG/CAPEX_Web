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
    
    public partial class SOL_Areas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOL_Areas()
        {
            this.SOL_Proyectos = new HashSet<SOL_Proyectos>();
            this.SOL_Sectores = new HashSet<SOL_Sectores>();
        }
    
        public int AREA_ID { get; set; }
        public string AREA_NOMBRE { get; set; }
        public string AREA_STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOL_Proyectos> SOL_Proyectos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOL_Sectores> SOL_Sectores { get; set; }
    }
}
