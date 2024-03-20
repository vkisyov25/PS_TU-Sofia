using DateLayer.Model;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;

namespace DateLayer.Database
{
    internal class DatabaseContext:DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        public DbSet<DatabaseLog> Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder =  Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();
            // Create a user
            var user = new DatabaseUser()
            {
                Id = 1,
                Name = "John Doe",
                Password = "1234",
                Roles = Welcome.Others.UserRolesEnum.ADMIN,
                Expires = DateTime.Now.AddYears(10)
            };

            var user1 = new DatabaseUser()
            {
                Id = 2,
                Name = "John Harry",
                Password = "1234",
                Roles = Welcome.Others.UserRolesEnum.STUDENT,
                Expires = DateTime.Now.AddYears(7)
            };

            var user2 = new DatabaseUser()
            {
                Id = 3,
                Name = "Vin Disel",
                Password = "1234",
                Roles = Welcome.Others.UserRolesEnum.PROFESSOR,
                Expires = DateTime.Now.AddYears(8)
            };
            modelBuilder.Entity<DatabaseUser>()
            .HasData(user);
        }

        
    }
}
