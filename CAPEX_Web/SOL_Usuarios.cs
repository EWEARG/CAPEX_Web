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
    
    public partial class SOL_Usuarios
    {
        public int ID_Usuario { get; set; }
        public string USUARIO_NOMBRE { get; set; }
        public string USUARIO_DESCRIPCION { get; set; }
        public Nullable<int> SECTOR_ID { get; set; }
        public Nullable<int> ORGANIZACION_ID { get; set; }
        public Nullable<bool> ID_ACTIVO { get; set; }
    
        public virtual SOL_Organizaciones SOL_Organizaciones { get; set; }
        public virtual SOL_Sectores SOL_Sectores { get; set; }
    }
}
