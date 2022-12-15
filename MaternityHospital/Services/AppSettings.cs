using MaternityHospital.DB.Models;
using MaternityHospital.Services.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    internal static class AppSettings
    {
        public static CurrentPatient currentPatient { get; set; }
        private static int _currentFontSize;
        public static int CurrentFontSize
        {
            get
            {
                return _currentFontSize;
            }
            set
            {
                string font = value.ToString();
                ConfigurationManager.AppSettings["CurrentFontSize"] = font;
                _currentFontSize = value;

            }
        }
        private static string _currentDoctor;
        public static string CurrentDoctor
        {
            get 
            { 
                return _currentDoctor ?? "???"; 
            }
            set 
            {
                ConfigurationManager.AppSettings["CurrentDoctor"] = value;
                _currentDoctor = value;
            }
        }

        public static List<IViewRepository> DefaultWindowsList { get; set; } = new List<IViewRepository>();

        public static void SetCurrentDoctor(Doctor doctor)
        {
            CurrentDoctor = doctor.FIO;
        }

        public static void SetAppSettings()
        {
            CurrentFontSize = int.Parse(ConfigurationManager.AppSettings["CurrentFontSize"]);
            CurrentDoctor = ConfigurationManager.AppSettings["CurrentDoctor"];
            SetWindows();
        }

        private static void SetWindows()
        {
            var list = new List<IViewRepository>();
            list.Add(new HeartVM());
        }
    }
}
