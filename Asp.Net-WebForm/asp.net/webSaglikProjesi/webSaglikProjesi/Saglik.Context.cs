﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webSaglikProjesi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaglikUrunleriEntities : DbContext
    {
        public SaglikUrunleriEntities()
            : base("name=SaglikUrunleriEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AltKategoriler> AltKategoriler { get; set; }
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
    }
}
