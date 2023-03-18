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
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
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

            //define pivot table between user and group
            modelBuilder.Entity<GroupUser>()
                .HasKey(gu => new { gu.UserId, gu.GroupId });

            modelBuilder.Entity<GroupUser>()
                .HasOne(gu => gu.User)
                .WithMany(u => u.GroupUsers)
                .HasForeignKey(gu => gu.UserId);

            modelBuilder.Entity<GroupUser>()
                .HasOne(gu => gu.Group)
                .WithMany(g => g.GroupUsers)
                .HasForeignKey(gu => gu.GroupId);

                

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, Name = "User" },
                new Role { RoleId = 2, Name = "Admin" },
                new Role { RoleId = 3, Name = "Contentbeheerder" }
                );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Pieter Post", Email = "pieter@post.nl", Password = EncryptPassword("pieter123"), RoleId = 1 },
                new User { UserId = 2, Name = "Albert Einstein", Email = "albert@post.nl", Password = EncryptPassword("albert123"), RoleId = 1 },
                new User { UserId = 3, Name = "Johannes Vermeer", Email = "johannes@post.nl", Password = EncryptPassword("johan123"), RoleId = 3 },
                new User { UserId = 4, Name = "adminName", Email = "admin", Password = EncryptPassword("admin123"), RoleId = 3 },
                new User { UserId = 5, Name = "Jarmo Marczinkowsky", Email = "jarmo@post.nl", Password = EncryptPassword("admin123"), RoleId = 2 });

            modelBuilder.Entity<Group>().HasData(
                new Group { GroupId = 1, Name = "TTB4-SSD3B", Size = 18 },
                new Group { GroupId = 2, Name = "TTB4_LG_SPEC_NAT_A", Size = 20 },
                new Group { GroupId = 3, Name = "TT_LG_VHBO", Size = 20 },
                new Group { GroupId = 4, Name = "TT_LG_PROMI", Size = 20 });

            modelBuilder.Entity<GroupUser>().HasData(
                new GroupUser { GroupId = 1, UserId = 1 },
                new GroupUser { GroupId = 2, UserId = 1 },
                new GroupUser { GroupId = 1, UserId = 2 },
                new GroupUser { GroupId = 2, UserId = 3 },
                new GroupUser { GroupId = 2, UserId = 4 }
                );
        }


        //create method that gets a string and returns a hashed string

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        //method that uses a sha 256 encryption to encrypt string
        public static string EncryptPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        //method that checks if sha256 password is correct
        
    }
}
