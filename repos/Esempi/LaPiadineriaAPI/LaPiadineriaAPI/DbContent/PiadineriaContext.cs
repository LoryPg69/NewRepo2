using LaPiadinereia.API.Models;
using laPiadineriaAPI.DbContent.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace laPiadineriaAPI.DbContent
{
    public class PiadineriaContext : DbContext
    {
        public DbSet<Piadina> Piada { get; set; } = null!;

        public DbSet<Drink> Drink { get; set; } = null!;

        public DbSet<Snack> Snacks { get; set; } = null!;

        public DbSet<Ingredient> Item { get; set; } = null!;


        public PiadineriaContext(DbContextOptions<PiadineriaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PiadinaEntities>().HasData(
                new Piada("Milano")
                {
                    Id = 1,
                    Description = "wwwww"
                },


                new City("Roma")
                {
                    Id = 2,
                    Description = "ssssss"
                }
                );

            modelBuilder.Entity<PointOfInternet>().HasData(

                new PointOfInternet("Duomo")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "bianco"
                },
                new PointOfInternet("Colosseo")
                {
                    Id = 2,
                    CityId = 2,
                    Description = "monument"
                }
                );

        }
    }
}
