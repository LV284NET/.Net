namespace EasyTravelWeb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EasyTravelDB : DbContext
    {
        public EasyTravelDB()
            : base("name=EasyTravelDB")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.cityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
