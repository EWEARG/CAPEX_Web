﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CAPEXEntities : DbContext
    {
        public CAPEXEntities()
            : base("name=CAPEXEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DIM_Fecha> DIM_Fecha { get; set; }
        public virtual DbSet<SOL_Areas> SOL_Areas { get; set; }
        public virtual DbSet<SOL_Centro_Costo> SOL_Centro_Costo { get; set; }
        public virtual DbSet<SOL_Estados> SOL_Estados { get; set; }
        public virtual DbSet<SOL_Organizaciones> SOL_Organizaciones { get; set; }
        public virtual DbSet<SOL_Presupuesto_BD> SOL_Presupuesto_BD { get; set; }
        public virtual DbSet<SOL_Proyectos> SOL_Proyectos { get; set; }
        public virtual DbSet<SOL_Sectores> SOL_Sectores { get; set; }
        public virtual DbSet<SOL_Usuarios> SOL_Usuarios { get; set; }
    
        public virtual ObjectResult<Proyectos_Resumen_Result> Proyectos_Resumen()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proyectos_Resumen_Result>("Proyectos_Resumen");
        }
    }
}
