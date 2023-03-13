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
        public DbSet<UserRole> UserRoles { get; set; }

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

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { UserRoleId = 1, Role = "User" },
                new UserRole { UserRoleId = 2, Role = "Admin" },
                new UserRole { UserRoleId = 3, Role = "Contentbeheerder" }
                );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Pieter Post", Email = "pieter@post.nl", Password = "pieter123", UserRoleId = 1 },
                new User { UserId = 2, Name = "Albert Einstein", Email = "albert@post.nl", Password = "albert123", UserRoleId = 1 },
                new User { UserId = 3, Name = "Johannes Vermeer", Email = "johannes@posalbt.nl", Password = "johan123", UserRoleId = 3 },
                new User { UserId = 4, Name = "Jarmo Marczinkowsky", Email = "jarmo@post.nl", Password = "admin123", UserRoleId = 2 });
        }
    }
}
