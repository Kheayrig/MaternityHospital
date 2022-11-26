using MaternityHospital.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MaternityHospital.DB.Repositories
{
    public class Patient : IRepository<Patient>
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public int PassportSeria { get; set; }
        public int PassportNumber { get; set; }
        public long Snils { get; set; }
        public string? Address { get; set; }
        public DateTime FirstScanDate { get; set; }
        public bool Dysmenorrhea { get; set; }
        public string Doctor { get; set; } = "Карпов А Ю ";
        public bool Scan { get; set; } = false;
        public bool DPM { get; set; } = false;

        private DateTime? _lastPeriodDate;
        #region Properties
        public DateTime? LastPeriodDate
        {
            get { return _lastPeriodDate; }
            set
            {
                if (value == null) Dysmenorrhea = true;
                else Dysmenorrhea = false;
                _lastPeriodDate = value;
            }
        }
        #endregion
        #region Constructors
        public Patient(string FIO, DateTime birthday, int passportSeria, int passportNumber, long snils,
             DateTime firstScanDate, string Doctor, string? address = null, DateTime? lastPeriodDate = null)
        {
            this.FIO = FIO;
            Birthday = birthday;
            PassportSeria = passportSeria;
            PassportNumber = passportNumber;
            Snils = snils;
            FirstScanDate = firstScanDate;
            Address = address;
            LastPeriodDate = lastPeriodDate;
            //Doctor = GetCurrentDoctor();
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{FIO} {Birthday} {Address}";
        }

        #endregion
        #region DB methods
        public static Patient GetById(int id)
        {
            using (var db = new ApplicationContext())
            {
                return db.Patients.FirstOrDefault(p => p.Id == id);
            }
        }

        public static List<Patient> GetAll()
        {
            using (var db = new ApplicationContext())
            {
                db.Patients.Load();
                return db.Patients.ToList();
            }
        }

        public static BindingList<Patient> GetAllTableView()
        {
            using (var db = new ApplicationContext())
            {
                db.Patients.Load();
                return db.Patients.Local.ToBindingList();
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.Patients.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.Patients.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.Patients.Remove(this);
                db.SaveChanges();
            }
        }
        #endregion
    }
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasAlternateKey(u => new { u.PassportNumber, u.PassportSeria });
            builder.HasAlternateKey(u => u.Snils);
        }
    }
}
