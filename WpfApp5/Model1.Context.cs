﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDWPFEntities : DbContext
    {
        public BDWPFEntities()
            : base("name=BDWPFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FIO> FIO { get; set; }
        public virtual DbSet<Nomer> Nomer { get; set; }
        public virtual DbSet<Zadolzhnost> Zadolzhnost { get; set; }
        public bool AllowFiltering { get; set; }

        internal static object GetContext()
        {
            throw new NotImplementedException();
        }
    }
}
