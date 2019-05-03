//------------------------------------------------------------------------------
// GENERADA por EWE
//
//     Implementa Herencia Parcial para completar la definición de la clase.
//     Define los atributos personalizados para utilizar en la pantalla.
// ref: https://www.geeksforgeeks.org/partial-classes-in-c-sharp/
// ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
// ref: OK https://patrickdesjardins.com/blog/why-it-is-wrong-to-use-the-asp-net-mvc-metadatatype-attribute
//-


namespace CAPEX_Web 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


   [MetadataType(typeof(SOL_Proyectos))]

    public partial class SOL_Proyectos { }

    public class SOL_ProyectosMetadata
    {
        [Column("ID_Proyecto")]
        [Display(Name = "ID Proyecto")]
        public object ID_Proyecto { get; set; }

        [Column("PROJECT_NUMBER")]
        [Required]
        [Display(Name = "# Proyecto")]
        [StringLength(25, ErrorMessage = "Numero de Proyecto no puede ser mayor de 25 characters.")]
        public object PROJECT_NUMBER { get; set; }

        [Column("PROYECTO_NOMBRE")]
        [Required]
        [Display(Name = "Nombre Proyecto")]
        // [Display(ShortName ="PROY.")]
        [StringLength(30, ErrorMessage = "Nombre de Proyecto no puede ser mayor de 30 characters.")]
        [MaxLength(30)]
        public object PROYECTO_NOMBRE { get; set; }

        [Column("NOMBRE_LARGO")]
        [Required]
        [Display(Name = "Nombre Largo")]
        [StringLength(150, ErrorMessage = "Nombre Largo no puede ser mayor de 150 characters.")]
        public object NOMBRE_LARGO { get; set; }

        [Column("DESCRIPCION")]
        [Display(Name = "Descripción del Proyecto")]
        [StringLength(250, ErrorMessage = "La Descripción no puede ser mayor de 250 characters.")]
        public object DESCRIPCION { get; set; }
        [Display(Name = "ID")]
        public object ESTADO_ID { get; set; }
        [Display(Name = "Estado Proy.")]
        public object PROYECTO_STATUS { get; set; }
        [Display(Name = "ID Area")]
        public object AREA_ID { get; set; }
        [Display(Name = "AREA")]
        public object AREA_NOMBRE { get; set; }
        [Display(Name = "ID Sector")]
        public object SECTOR_ID { get; set; }

        [Display(Name = "SECTOR")]
        public object SECTOR_NOMBRE { get; set; }

        [Display(Name = "ID Org")]
        public object ORGANIZACION_ID { get; set; }
        [Display(Name = "ORGANIZACIÓN")]
        public object ORGANIZACION_NOMBRE { get; set; }
        [Display(Name = "Tipo Proy.")]
        public object PROYECTO_TYPE { get; set; }

        [Display(Name = "TIPO PROYECTO")]
        public object PROYECTO_TYPE_DESCRIPTION { get; set; }

        [Display(Name = "DIVISA")]
        public object PROYECTO_DIVISA { get; set; }
        [Display(Name = "MONTO DIVISA")]
        public object MONTO_DIVISA { get; set; }
        [Display(Name = "MONTO CONVERTIDO")]
        public object MONTO_CONVERTIDO { get; set; }
        [Display(Name = "MONTO PRESUPUESTADO")]
        public object MONTO_PRESUPUESTADO { get; set; }
    }
}