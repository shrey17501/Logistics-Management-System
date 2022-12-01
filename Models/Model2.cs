using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace logistics.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<export> exports { get; set; }
        public virtual DbSet<import> imports { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<export>()
                .Property(e => e.shoes_type)
                .IsUnicode(false);

            modelBuilder.Entity<export>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<export>()
                .Property(e => e.export_address)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.county)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.shoes_type)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
