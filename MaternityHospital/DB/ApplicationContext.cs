using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MaternityHospital.DB
{
    internal class ApplicationContext : DbContext
    {
        readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        public DbSet<Patient> Patients { get; set; } = null!;
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message), LogLevel.Debug);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new PatientConfiguration());
        }
    }
}
