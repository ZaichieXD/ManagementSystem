using ManagementSystem.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Configurations
{
    public class EmployeeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["EmployeeDbContext"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Employee> EmployeeModel { get; set; }
        public DbSet<Projects> ProjectsModel { get; set; }
        public DbSet<Reports> ReportsModel { get; set; }
        public DbSet<News> NewsModel { get; set; }
    }
}
