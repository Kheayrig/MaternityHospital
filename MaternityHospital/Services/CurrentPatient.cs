using MaternityHospital.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    public class CurrentPatient
    {
        public Patient Patient { get; set; }
        public List<IViewRepository> Windows { get; } = new List<IViewRepository>();
        public int Trimestre { get; set; }
        public CurrentPatient(Patient patient)
        {
            Patient = patient;
            if(Patient.PregnancyDuration < 18) Trimestre = 1;
            else if (Patient.PregnancyDuration < 30) Trimestre = 2;
            else if (Patient.PregnancyDuration < 35) Trimestre = 3;
            else Trimestre = 4;
        }
        public void AddWindow(IViewRepository window)
        {
            Windows.Add(window);
        }
    }
}
