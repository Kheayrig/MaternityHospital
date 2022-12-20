using MaternityHospital.DB.Repositories;
using MaternityHospital.Services;
using System;
using System.Linq;

namespace MaternityHospital.DB.Models
{
    public class Visit : IRepository
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public int Trimester { get; set; }
        public string Doctor { get; set; }

        public Visit (Patient patient, DateTime visitDate, int trimester, string doctor)
        {
            PatientId = patient.Id;
            VisitDate = visitDate;
            Trimester = trimester;
            Doctor = doctor;
        }
        public Visit (int patientId, DateTime visitDate, int trimester, string doctor)
        {
            PatientId = patientId;
            VisitDate = visitDate;
            Trimester = trimester;
            Doctor = doctor;
        }

        public void GetBy(int patientId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.Visits.OrderByDescending(c => c.VisitDate).First(c => c.PatientId == patientId);
                Id = temp.Id;
                PatientId = temp.PatientId;
                VisitDate = temp.VisitDate;
                Trimester = temp.Trimester;
                Doctor = temp.Doctor;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.Visits.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.Visits.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.Visits.Remove(this);
                db.SaveChanges();
            }
        }

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(Visit).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
