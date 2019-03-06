using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netApi.Models
{
    public partial class apiContext : DbContext
    {
        public apiContext()
        {
        }

        public apiContext(DbContextOptions<apiContext> options)
            : base(options)
        {
        }

        public DbSet<Information> Information { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LENOVO-PC;Database=api;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Information>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.Property(e => e.InfoId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Info)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
