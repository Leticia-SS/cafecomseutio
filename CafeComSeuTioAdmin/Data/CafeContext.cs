﻿using CafeComSeuTioAdmin.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CafeComSeuTioAdmin.Data
{
    public class IdentidadeContext : IdentityDbContext
    {
        public IdentidadeContext(DbContextOptions<IdentidadeContext> options) 
            : base(options) 
        {
            
        }
    }

    public class CafeContext : DbContext
    {
        public CafeContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<Product>().HasData(
          new Product()
          {
              Id = 33,
              Name = "Charcuterie",
              ShortDescription = "For indecisive food afficianados.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "charcuterie.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 12,
              Name = "Waffles",
              ShortDescription = "They need no introduction.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "waffles.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 13,
              Name = "Santa Fe Salad",
              ShortDescription = "Our house special - we love it.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "salad-special.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 14,
              Name = "Caesar Salad",
              ShortDescription = "Classically, delicious fresh.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "salad-house.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 15,
              Name = "Noodles",
              ShortDescription = "Delicious carbs on the go.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "noodles.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 16,
              Name = "Red Velvet Cake",
              ShortDescription = "Red Velvet...for those who prefer finer things.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "cake.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 17,
              Name = "Cupcake",
              ShortDescription = "Vanilla cupcakes with the perfect level of sweetness.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "cupcake.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 18,
              Name = "Muffin",
              ShortDescription = "The perfect way to start a Monday morning.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "muffin.png",
              Price = 3,
              Category = "Food",
          },
          new Product()
          {
              Id = 19,
              Name = "Chocolate Bites",
              ShortDescription = "Rich and sweet chocolate bites for those in need of a special treat.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "chocolate.png",
              Price = 5,
              Category = "Food",
          },
          new Product()
          {
              Id = 20,
              Name = "Frosted Pumpkin Bread",
              ShortDescription = "A seasonal delight we offer every autumn.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "pumpkinbread.png",
              Price = 4,
              Category = "Food",
          },
          new Product()
          {
              Id = 21,
              Name = "Granola with Nuts",
              ShortDescription = "It's not flashy, but it sure is healthy.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "granola.png",
              Price = 3,
              Category = "Food",
          },
          new Product()
          {
              Id = 22,
              Name = "Chocolate Chip Cookies",
              ShortDescription = "They're made fresh every day, and they taste like it.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "cookies.png",
              Price = 2,
              Category = "Food",
          },
          new Product()
          {
              Id = 23,
              Name = "Fresh Bagels",
              ShortDescription = "They're just as round as donuts, but far more healthy!",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "bagel.png",
              Price = 5,
              Category = "Food",
          },
          new Product()
          {
              Id = 24,
              Name = "Dark Brewed Coffee",
              ShortDescription = "A classic, refreshing original.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "ground.png",
              Price = 2,
              Category = "Coffee",
          },
          new Product()
          {
              Id = 25,
              Name = "Latte",
              ShortDescription = "More than just coffee, but still just coffee.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "cappucino.png",
              Price = 3,
              Category = "Coffee",
          },
          new Product()
          {
              Id = 26,
              Name = "Americano",
              ShortDescription = "Still classic, but a little more sophisticated.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "beans.png",
              Price = 3.5M,
              Category = "Coffee",
          },
          new Product()
          {
              Id = 27,
              Name = "Designer Espresso",
              ShortDescription = "Caffine has never looked so stunning.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "design.png",
              Price = 6.5M,
              Category = "Coffee",
          },
          new Product()
          {
              Id = 28,
              Name = "Cappucino",
              ShortDescription = "Rich and foamy comfort coffee.",
              Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
              ImageFileName = "cup.png",
              Price = 4.5M,
              Category = "Coffee",
          }
          );
            }
        }
        public DbSet<CafeComSeuTioAdmin.Data.Models.City> City { get; set; }
    }
}
