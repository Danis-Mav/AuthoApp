﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthoApp.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DelikEntities : DbContext
    {
        public DelikEntities()
            : base("name=DelikEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Custumer> Custumer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Pen> Pen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeCustomer> TypeCustomer { get; set; }
        public virtual DbSet<TypePen> TypePen { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
