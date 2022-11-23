using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace MaternityHospital.DB.Repositories
{
    public static class PatientsRepository
    {
        public static void Add(Patient patient)
        {
            using (var db = new ApplicationContext())
            {
                db.Patients.Add(patient);
                db.SaveChanges();
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
    }
}
