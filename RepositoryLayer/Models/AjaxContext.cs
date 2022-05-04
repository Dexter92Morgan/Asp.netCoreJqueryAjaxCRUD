using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RepositoryLayer.Models
{
    public partial class AjaxContext : DbContext
    {
        public AjaxContext()
        {
        }

        public AjaxContext(DbContextOptions<AjaxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDesgnation> TblDesgnation { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDesgnation>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.Property(e => e.Designation).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
