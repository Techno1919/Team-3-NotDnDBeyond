﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RpgInfinity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RPGInfinityEntities : DbContext
    {
        public RPGInfinityEntities()
            : base("name=RPGInfinityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        public System.Data.Entity.DbSet<RpgInfinity.Models.Character> Characters { get; set; }
    }
}
