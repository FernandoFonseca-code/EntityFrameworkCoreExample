using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample
{
    // EF Core Getting Started
    // https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is included with Visual Studio
            // Trusted_Connection = True means we are using Windows Authentication
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_connection=True;");
        }

        // Tell EF Core to track Students in the database
        public DbSet<Student> Students { get; set; }
    }
}
