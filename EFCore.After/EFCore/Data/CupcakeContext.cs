﻿using Cupcakes.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cupcakes.Data
{
    public class CupcakeContext : DbContext
    {
        public CupcakeContext(DbContextOptions<CupcakeContext> options) : base(options)
        {
        }

        public DbSet<Cupcake> Cupcakes { get; set; }
        public DbSet<Bakery> Bakeries { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=Cupcake");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cupcake>()
            //    .HasOne(t => t.Bakery)
            //    .WithOne(t => t.Cupcakes);


            modelBuilder.Entity<Bakery>().HasData(
               new Bakery
               {
                   BakeryId = 1,
                   BakeryName = "Gluteus Free",
                   Address = "635 Brighton Circle Road",
                   Quantity = 8
               },
                new Bakery
                {
                    BakeryId = 2,
                    BakeryName = "Cupcakes Break",
                    Address = "4323 Jerome Avenue",
                    Quantity = 22
                },
                new Bakery
                {
                    BakeryId = 3,
                    BakeryName = "Cupcakes Ahead",
                    Address = "2553 Pin Oak Drive",
                    Quantity = 18
                },
                new Bakery
                {
                    BakeryId = 4,
                    BakeryName = "Sugar",
                    Address = "1608 Charles Street",
                    Quantity = 30
                }
            );

            modelBuilder.Entity<Cupcake>().HasData(
                new Cupcake
                {
                    CupcakeId = 1,
                    CupcakeType = CupcakeType.Birthday,
                    Description = "Vanilla cupcake with coconut cream",
                    GlutenFree = true,
                    Price = 2.5,
                    BakeryId = 1,
                    CaloricValue = 355,
                    Discount= 0.5
                },
                new Cupcake
                {
                    CupcakeId = 2,
                    CupcakeType = CupcakeType.Chocolate,
                    Description = "Chocolate cupcake with caramel filling and chocolate butter cream",
                    GlutenFree = false,
                    Price = 3.2,
                    BakeryId = 2,
                    CaloricValue = 195,
                    Discount = 1
                },
                new Cupcake
                {
                    CupcakeId = 3,
                    CupcakeType = CupcakeType.Strawberry,
                    Description = "Chocolate cupcake with straberry cream filling",
                    GlutenFree = false,
                    Price = 4,
                    BakeryId = 3,
                    CaloricValue = 295,
                    Discount = null
                },
                new Cupcake
                {
                    CupcakeId = 4,
                    CupcakeType = CupcakeType.Turquoise,
                    Description = "Vanilla cupcake with butter cream",
                    GlutenFree = true,
                    Price = 1.5,
                    BakeryId = 4,
                    CaloricValue = 360
                }
            );
        }
    }
}