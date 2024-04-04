using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DataAcc
{
    public class UserAcc : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Shop>().ToTable("Shop");
            modelBuilder.Entity<UserCart>().ToTable("UserCart");
            modelBuilder.Entity<Pension>().ToTable("Pension");

        }
        //get , set
        public DbSet<User> Users { get; set; }
        public DbSet<Shop> Products { get; set; }
        public DbSet<UserCart> CProducts { get; set; }
        public DbSet<Pension> pension { get; set; }

    }
}