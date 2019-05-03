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
    
    public partial class SOL_Proyectos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOL_Proyectos()
        {
            this.SOL_Presupuesto_BD = new HashSet<SOL_Presupuesto_BD>();
        }
    
        public int ID_Proyecto { get; set; }
        public string PROJECT_NUMBER { get; set; }
        public string PROYECTO_NOMBRE { get; set; }
        public string NOMBRE_LARGO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> ESTADO_ID { get; set; }
        public string PROYECTO_STATUS { get; set; }
        public Nullable<int> AREA_ID { get; set; }
        public string AREA_NOMBRE { get; set; }
        public Nullable<int> SECTOR_ID { get; set; }
        public string SECTOR_NOMBRE { get; set; }
        public Nullable<int> ORGANIZACION_ID { get; set; }
        public string ORGANIZACION_NOMBRE { get; set; }
        public string PROYECTO_TYPE { get; set; }
        public string PROYECTO_TYPE_DESCRIPTION { get; set; }
        public string PROYECTO_DIVISA { get; set; }
        public Nullable<decimal> MONTO_DIVISA { get; set; }
        public Nullable<decimal> MONTO_CONVERTIDO { get; set; }
        public Nullable<decimal> MONTO_PRESUPUESTADO { get; set; }
        public string DISTRIBUTION_RULE { get; set; }
        public string DISTRIBUTION_RULE_MEANING { get; set; }
        public string CONTEXT_VALUE { get; set; }
        public string PROYECTO_CON_PRESUPUESTO { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_ESTIMADO { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_REAL { get; set; }
        public Nullable<int> DURACION_ESTIMADA_MESES { get; set; }
        public Nullable<System.DateTime> INGRESO_DATE { get; set; }
        public Nullable<System.DateTime> ESTIMADO_DATE { get; set; }
        public Nullable<System.DateTime> PRESUPUESTADO_DATE { get; set; }
        public Nullable<System.DateTime> COMPLETADO_DATE { get; set; }
        public Nullable<System.DateTime> ACTUALIZADO_DATE { get; set; }
        public string ACTUALIZADO_POR { get; set; }
        public System.DateTime CREADO_DATE { get; set; }
        public string CREADO_POR { get; set; }
    
        public virtual SOL_Areas SOL_Areas { get; set; }
        public virtual SOL_Organizaciones SOL_Organizaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOL_Presupuesto_BD> SOL_Presupuesto_BD { get; set; }
        public virtual SOL_Sectores SOL_Sectores { get; set; }
        public virtual SOL_Estados SOL_Estados { get; set; }
    }
}
