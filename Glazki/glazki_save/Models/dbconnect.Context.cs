//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace glazki_save.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class blagodatEntities : DbContext
    {
        public blagodatEntities()
            : base("name=blagodatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<zakazy> zakazy { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<uslugi> uslugi { get; set; }

        public static user CurrentUser = null;
    }
}
