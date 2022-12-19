using MaternityHospital.DB.Models;
using MaternityHospital.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Windows;

namespace MaternityHospital.DB.Repositories
{
    public class Patient : IRepository
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public string? Address { get; set; }
        public DateTime FirstScanDate { get; set; }
        public bool Dysmenorrhea { get; set; }
        public bool Scan { get; set; } = false;
        public bool DPM { get; set; } = false;
        private DateTime? _lastPeriodDate;
        public int PregnancyDurationWeek { get; set; }
        public int PregnancyDurationDay { get; set; }
        [NotMapped]
        private IPregnancyCalculator _pregnancyCalculator;
        [NotMapped]
        public int Trimester { get; set; }
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
        public Patient(string FIO, DateTime birthday, DateTime firstScanDate,
            string? address = null, DateTime? lastPeriodDate = null, int pregnancyDurationWeek = 0, int pregnancyDurationDay = 0)
        {
            this.FIO = FIO;
            Birthday = birthday;
            FirstScanDate = firstScanDate;
            Address = address;
            LastPeriodDate = lastPeriodDate;
            PregnancyDurationWeek = pregnancyDurationWeek;
            PregnancyDurationDay = pregnancyDurationDay;
            _pregnancyCalculator = new PregnancyCalculator(LastPeriodDate, PregnancyDurationWeek, PregnancyDurationDay);
            PregnancyDurationWeek = _pregnancyCalculator.GetPregnancyDurationWeek();
            PregnancyDurationDay = _pregnancyCalculator.GetPregnancyDurationDay();
            Trimester = _pregnancyCalculator.GetTrimester();
        }
        public Patient(string FIO, DateTime birthday, DateTime firstScanDate, IPregnancyCalculator? pregnancyCalculator,
            string? address = null, DateTime? lastPeriodDate = null, int pregnancyDurationWeek = 0, int pregnancyDurationDay = 0)
        {
            this.FIO = FIO;
            Birthday = birthday;
            FirstScanDate = firstScanDate;
            Address = address;
            LastPeriodDate = lastPeriodDate;
            PregnancyDurationWeek = pregnancyDurationWeek;
            PregnancyDurationDay = pregnancyDurationDay;
            _pregnancyCalculator = pregnancyCalculator ?? new PregnancyCalculator(LastPeriodDate, PregnancyDurationWeek, PregnancyDurationDay);
            PregnancyDurationWeek = _pregnancyCalculator.GetPregnancyDurationWeek();
            PregnancyDurationDay = _pregnancyCalculator.GetPregnancyDurationDay();
            Trimester = _pregnancyCalculator.GetTrimester();
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{FIO} {Birthday} {Address}";
        }

        #endregion
        #region DB methods
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
                var res = db.Patients.Local.ToBindingList();
                return res;
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

        public void GetBy(int Id)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.Patients.First(c => c.Id == Id);
                Id = temp.Id;
                FIO = temp.FIO;
                Birthday = temp.Birthday;
                FirstScanDate = temp.FirstScanDate;
                Address = temp.Address;
                LastPeriodDate = temp.LastPeriodDate;
                PregnancyDurationWeek = temp.PregnancyDurationWeek;
                PregnancyDurationDay = temp.PregnancyDurationDay;
                _pregnancyCalculator = temp._pregnancyCalculator ?? new PregnancyCalculator(LastPeriodDate, PregnancyDurationWeek, PregnancyDurationDay);
                PregnancyDurationWeek = temp._pregnancyCalculator.GetPregnancyDurationWeek();
                PregnancyDurationDay = temp._pregnancyCalculator.GetPregnancyDurationDay();
                Trimester = temp._pregnancyCalculator.GetTrimester();
            }
        }
        #endregion
    }
}
