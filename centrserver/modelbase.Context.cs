﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace centrserver
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class speedrunEntities3 : DbContext
    {
        private static speedrunEntities3 _context;
        public speedrunEntities3()
            : base("name=speedrunEntities3")
        {
        }
        public static speedrunEntities3 GetContext()
        {
            if (_context == null )
                _context = new speedrunEntities3();
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AFSInfo> AFSInfo { get; set; }
        public virtual DbSet<bankCard> bankCard { get; set; }
        public virtual DbSet<bonusCard> bonusCard { get; set; }
        public virtual DbSet<Colonka> Colonka { get; set; }
        public virtual DbSet<fuel_data1> fuel_data1 { get; set; }
        public virtual DbSet<fuel_data2> fuel_data2 { get; set; }
        public virtual DbSet<fuel_data3> fuel_data3 { get; set; }
        public virtual DbSet<fuel_data4> fuel_data4 { get; set; }
        public virtual DbSet<Fuel_Reserve> Fuel_Reserve { get; set; }
        public virtual DbSet<numberInfo> numberInfo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<transaction> transaction { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}