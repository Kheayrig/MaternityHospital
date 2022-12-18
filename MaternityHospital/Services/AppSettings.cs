using MaternityHospital.DB.Models;
using System.Collections.Generic;

namespace MaternityHospital.Services
{
    internal static class AppSettings
    {
        public static CurrentPatient currentPatient { get; set; } = null;
        public static List<IViewRepository> DefaultWindowsList { get; set; } = new List<IViewRepository>();
        public static CustomSettings customSettings { get; set; } = new CustomSettings();

        public static void SetCurrentDoctor(Doctor doctor)
        {
            customSettings.CurrentDoctor = doctor.FIO;
        }

        public static void SetWindows(List<IViewRepository> windows)
        {
            DefaultWindowsList = windows;
        }
    }
    
}
