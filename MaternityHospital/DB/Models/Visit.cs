using MaternityHospital.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models
{
    public class Visit
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
    }
}
