﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CozBank.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class veksisd1_CozBank_DBEntities : DbContext
    {
        public veksisd1_CozBank_DBEntities()
            : base("name=veksisd1_CozBank_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Histories> Histories { get; set; }
        public virtual DbSet<TransferHistories> TransferHistories { get; set; }
        public virtual DbSet<Actors> Actors { get; set; }
        public virtual DbSet<ActorTypes> ActorTypes { get; set; }
        public virtual DbSet<Lookups> Lookups { get; set; }
        public virtual DbSet<LookupTypes> LookupTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}