﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupplierEvaluation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbSCMEntities2 : DbContext
    {
        public dbSCMEntities2()
            : base("name=dbSCMEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PU_EvaluateSupplier> PU_EvaluateSupplier { get; set; }
        public virtual DbSet<PU_EvaluateSupplierResult> PU_EvaluateSupplierResult { get; set; }
        public virtual DbSet<vd_mstr> vd_mstr { get; set; }
        public virtual DbSet<AL_Vendor> AL_Vendor { get; set; }
    }
}