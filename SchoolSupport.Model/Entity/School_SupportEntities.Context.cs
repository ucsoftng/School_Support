﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSupport.Model.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class School_SupportEntities : DbContext
    {
        public School_SupportEntities()
            : base("name=School_SupportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DEPARTMENT> DEPARTMENT { get; set; }
        public virtual DbSet<FACULTY> FACULTY { get; set; }
        public virtual DbSet<PROGRAMME> PROGRAMME { get; set; }
        public virtual DbSet<SCHOOL> SCHOOL { get; set; }
        public virtual DbSet<SESSION> SESSION { get; set; }
        public virtual DbSet<SEX> SEX { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<ROLE> ROLE { get; set; }
        public virtual DbSet<STUDENT_CATEGORY> STUDENT_CATEGORY { get; set; }
        public virtual DbSet<DEPARTMENT_OPTION> DEPARTMENT_OPTION { get; set; }
        public virtual DbSet<SECURITY_QUESTION> SECURITY_QUESTION { get; set; }
        public virtual DbSet<LEVEL> LEVEL { get; set; }
        public virtual DbSet<PERSON> PERSON { get; set; }
        public virtual DbSet<STUDENT_LEVEL> STUDENT_LEVEL { get; set; }
        public virtual DbSet<STUDENT> STUDENT { get; set; }
        public virtual DbSet<TICKET> TICKET { get; set; }
    }
}