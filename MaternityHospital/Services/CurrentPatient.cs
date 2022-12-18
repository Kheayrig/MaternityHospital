﻿using MaternityHospital.DB.Repositories;
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
        public List<IViewRepository> Windows { get; set; } = new List<IViewRepository>();
        public CurrentPatient(Patient patient)
        {
            Patient = patient;
        }
    }
}
