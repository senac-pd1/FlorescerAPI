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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planta>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Planta>()
                .Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Categorie)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Desease)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Img)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Use)
                .HasConversion(
                    v=> string.Join(',', v), 
                    v=> v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                )
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.LatinName)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Insect)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                )
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Avaibility)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Style)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Bearing)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.LightTolered)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.HeightAtPurchase)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.LightIdeal)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.WidthAtPurchase)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Appeal)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Perfume)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Growth)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.WidthPotential)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Name)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Pruning)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Family)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.HeightPotential)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Origin)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                )
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Description)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.TemperatureMax)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.BloomingSeason)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Url)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.ColorOfLeaf)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                )
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Watering)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.ColorOfBloom)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Zone)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                )
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.AvaibleSizesPot)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.OtherName)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.TemperatureMin)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.PotDiameter)
                .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, double>>(v))
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .Property(p => p.Climat)
                .HasColumnType("varchar");

            modelBuilder.Entity<Planta>()
                .ToTable("Plantas");


            base.OnModelCreating(modelBuilder);
        }
    }
}
