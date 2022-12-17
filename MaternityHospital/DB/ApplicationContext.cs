using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaternityHospital.DB.Models;
using MaternityHospital.DB.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MaternityHospital.DB
{
    internal class ApplicationContext : DbContext
    {
        readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        public DbSet<Doctor> Doctors { get; set; } = null!;
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
            modelBuilder.Entity<Doctor>().HasAlternateKey(u => u.FIO);
        }
    }
    internal class ArchiveApplicationContext : DbContext
    {
        readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionArchive"].ConnectionString;

        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public ArchiveApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message), LogLevel.Debug);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasAlternateKey(u => u.FIO);
        }
    }
    internal class TemplateApplicationContext : DbContext
    {
        readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionTemplate"].ConnectionString;

        public DbSet<PercentileCorridors> TemplateValues { get; set; } = null!;
        public TemplateApplicationContext() { 
            Database.EnsureCreated();
            PercentileCorridors.AddDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message), LogLevel.Debug);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
