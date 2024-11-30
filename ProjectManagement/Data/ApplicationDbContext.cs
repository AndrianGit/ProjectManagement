using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;
namespace ProjectManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProjectItem> ProjectItemTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProjectDb;Trusted_Connection=True;");
        }
    }
}