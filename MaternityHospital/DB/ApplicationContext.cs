using System;
using System.Configuration;
using MaternityHospital.DB.Models;
using MaternityHospital.DB.Models.ExtraViewClasses;
using MaternityHospital.DB.Models.ViewClasses;
using MaternityHospital.DB.Repositories;
using MaternityHospital.Services;
using MaternityHospital.Services.ViewClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MaternityHospital.DB
{
    internal class ApplicationContext : DbContext
    {
        readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;

        public DbSet<Visit> Visits { get; set; } = null!;
        public DbSet<Obschiesvedenia> obschieSvedenia { get; set; } = null!;
        public DbSet<Fetometria> fetometria { get; set; } = null!;
        public DbSet<RasshirennOsmotr> rasshirennOsmotr { get; set; } = null!;
        public DbSet<Dopplerometria> dopplerometria { get; set; } = null!;
        public DbSet<Translabialnoe> translabialnoe { get; set; } = null!;
        public DbSet<Transperinealnoe> transperinealnoe { get; set; } = null!;
        public DbSet<MalSroki> malSroki { get; set; } = null!;
        public DbSet<Report> reports { get; set; } = null!;

        public DbSet<AbdominalCavity> abdominalCavity { get; set; } = null!;
        public DbSet<Chestcavity> chestcavity { get; set; } = null!;
        public DbSet<CnsFaceNeck> cnsFaceNeck { get; set; } = null!;
        public DbSet<HeartVM> heartVM { get; set; } = null!;
        public DbSet<Pypovina> pypovina { get; set; } = null!;
        public DbSet<Skelet> skelet { get; set; } = null!;
        public ApplicationContext() => Database.EnsureCreated();

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
    internal class ArchiveApplicationContext : DbContext
    {
        readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionArchive"].ConnectionString;

        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;

        public DbSet<Visit> Visits { get; set; } = null!;

        public DbSet<Obschiesvedenia> obschieSvedenia { get; set; } = null!;
        public DbSet<Fetometria> fetometria { get; set; } = null!;
        public DbSet<RasshirennOsmotr> rasshirennOsmotr { get; set; } = null!;
        public DbSet<Dopplerometria> dopplerometria { get; set; } = null!;
        public DbSet<Translabialnoe> translabialnoe { get; set; } = null!;
        public DbSet<Transperinealnoe> transperinealnoe { get; set; } = null!;
        public DbSet<MalSroki> malSroki { get; set; } = null!;
        public DbSet<Report> reports { get; set; } = null!;

        public DbSet<AbdominalCavity> abdominalCavity { get; set; } = null!;
        public DbSet<Chestcavity> chestcavity { get; set; } = null!;
        public DbSet<CnsFaceNeck> cnsFaceNeck { get; set; } = null!;
        public DbSet<HeartVM> heartVM { get; set; } = null!;
        public DbSet<Pypovina> pypovina { get; set; } = null!;
        public DbSet<Skelet> skelet { get; set; } = null!;

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
