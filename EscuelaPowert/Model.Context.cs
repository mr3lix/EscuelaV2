﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscuelaPowert
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EscuelaEntitys : DbContext
    {
        public EscuelaEntitys()
            : base("name=EscuelaEntitys")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actividade> Actividades { get; set; }
        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Asistencia> Asistencias { get; set; }
        public virtual DbSet<Ciclo> Cicloes { get; set; }
        public virtual DbSet<Clase> Clases { get; set; }
        public virtual DbSet<Evaluacion> Evaluacions { get; set; }
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<Grupo_Info> Grupo_Info { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Plan_Estudio> Plan_Estudio { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }
        public virtual DbSet<Tipo_Actividad> Tipo_Actividad { get; set; }
    }
}