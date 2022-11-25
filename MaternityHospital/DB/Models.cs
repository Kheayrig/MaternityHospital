using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityHospital.DB
{
    public class Patient
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public int PassportSeria { get; set; }
        public int PassportNumber { get; set; }
        public int Snils { get; set; }
        public string? Address { get; set; }
        public DateTime? _lastPeriodDate;
        public DateTime FirstScanDate { get; set; }
        public bool Dysmenorrhea { get; set; }
        #region Properties
        public DateTime? LastPeriodDate
        {
            get { return _lastPeriodDate; }
            set
            {
                if(value == null) Dysmenorrhea = true;
                else Dysmenorrhea = false;
                _lastPeriodDate = value;
            }
        }
        #endregion
        #region Constructors
        public Patient(string FIO, DateTime birthday, int passportSeria, int passportNumber, int snils,
             DateTime firstScanDate, string? address = null, DateTime? lastPeriodDate = null)
        {
            this.FIO = FIO;
            Birthday = birthday;
            PassportSeria = passportSeria;
            PassportNumber = passportNumber;
            Snils = snils;
            FirstScanDate = firstScanDate;
            Address = address;
            LastPeriodDate = lastPeriodDate;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{FIO} {Birthday} {Address}";
        }
        #endregion
        #region DB_settings

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
