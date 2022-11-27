using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    internal static class Settings
    {
        public static string GetCurrentDoctor()
        {
            return ConfigurationManager.AppSettings["CurrentDoctor"] ?? "???";
        }
        public static void SetCurrentDoctor(Doctor doctor)
        {
            ConfigurationManager.AppSettings["CurrentDoctor"] = doctor.FIO;
        }
        public static void SetCurrentDoctor(string doctorName)
        {
            ConfigurationManager.AppSettings["CurrentDoctor"] = doctorName;
        }
    }
}
