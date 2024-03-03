﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SalonEntities : DbContext
    {
        public SalonEntities()
            : base("name=SalonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<citas> citas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
    
        public virtual ObjectResult<Mostrar_Citas_Result> Mostrar_Citas(Nullable<System.DateTime> fecha)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Mostrar_Citas_Result>("Mostrar_Citas", fechaParameter);
        }
    
        public virtual ObjectResult<Mostrar_Citas_Nuevo_Result> Mostrar_Citas_Nuevo(Nullable<System.DateTime> fecha)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Mostrar_Citas_Nuevo_Result>("Mostrar_Citas_Nuevo", fechaParameter);
        }
    }
}
