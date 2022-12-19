using MaternityHospital.DB.Models;
using MaternityHospital.DB.Repositories;
using System.Collections.Generic;

namespace MaternityHospital.Services
{
    internal static class AppSettings
    {
        public static Patient CurrentPatient { get; set; } = null;
        public static List<IRepository> WindowsList { get; set; } = new List<IRepository>();
        public static CustomSettings CustomSettings { get; set; } = new CustomSettings();
        public static Visit CurrentVisit { get; set; }
        public static bool isUpdating { get; set; } = false;

        public static void SetCurrentDoctor(Doctor doctor)
        {
            CustomSettings.CurrentDoctor = doctor.FIO;
        }
    }
    
}
