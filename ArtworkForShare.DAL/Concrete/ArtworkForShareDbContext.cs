using ArtworkForShare.DAL.Concrete.EntityTypeConfiguration;
using ArtworkForShare.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete
{
    class ArtworkForShareDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres; Password=........; Server=localhost; Database=ArtworkForShareDb;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Desire> Claims { get; set; }        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtworkMapping());            
            modelBuilder.ApplyConfiguration(new ClaimMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
