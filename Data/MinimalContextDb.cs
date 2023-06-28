using FlorescerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace FlorescerAPI.Data
{
    public class MinimalContextDb : DbContext
    {
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }

        public DbSet<Planta> Plantas { get; set; }

        public DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Planta Modeling
            modelBuilder.Entity<Planta>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Planta>()
                .Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Img)
                .HasColumnType("varchar");


            modelBuilder.Entity<Planta>()
                .Property(p => p.Growth)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Family)
                .HasColumnType("varchar");


            modelBuilder.Entity<Planta>()
                .Property(p => p.Irrigation)
                .HasColumnType("varchar");


            modelBuilder.Entity<Planta>()
                .Property(p => p.Climate)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.ScientificName)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .ToTable("Plantas");

            //Wishlist Modeling
            modelBuilder.Entity<Wishlist>()
                .ToTable("Wishlist");

            modelBuilder.Entity<Wishlist>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Wishlist>()
                .Property(p =>  p.UserId)
                .HasColumnType("varchar");

            modelBuilder.Entity<Wishlist>()
                .Property(p => p.PlantaId)
                .HasColumnType("varchar");

            base.OnModelCreating(modelBuilder);
        }
    }
}
