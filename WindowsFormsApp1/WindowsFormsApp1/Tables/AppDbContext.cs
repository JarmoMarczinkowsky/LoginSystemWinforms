using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Tables
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(
                "server=localhost;database=TestLoginSystem;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seeder

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, Name = "User" },
                new Role { RoleId = 2, Name = "Admin" },
                new Role { RoleId = 3, Name = "Contentbeheerder" }
                );


            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Pieter Post", Email = "pieter@post.nl", Password = HashPassword("pieter123"), RoleId = 1 },
                new User { UserId = 2, Name = "Albert Einstein", Email = "albert@post.nl", Password = HashPassword("albert123"), RoleId = 1 },
                new User { UserId = 3, Name = "Johannes Vermeer", Email = "johannes@post.nl", Password = HashPassword("johan123"), RoleId = 3 },
                new User { UserId = 4, Name = "adminName", Email = "admin", Password = HashPassword("admin123"), RoleId = 3 },
                new User { UserId = 5, Name = "Jarmo Marczinkowsky", Email = "jarmo@post.nl", Password = HashPassword("admin123"), RoleId = 2 });
        }

        //create method that gets a string and returns a hashed string

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
