using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models
{
    internal class PercentileCorridors
    {
        [Key]
        public int Week { get; set; }

        public int MinMass { get; set; }
        public int MaxMass { get; set; }

        public int MinBR { get; set; }
        public int MaxBR { get; set; }

        public int MinDB { get; set; }
        public int MaxDB { get; set; }

        public int MinOZh { get; set; }
        public int MaxOZh { get; set; }

        public int MinDGK { get; set; }
        public int MaxDGK { get; set; }

        internal PercentileCorridors(int week, int minMass, int maxMass, int minBR, int maxBR, int minDB, int maxDB, int minOZh, int maxOZh, int minDGK, int maxDGK)
        {
            Week = week;
            MinMass = minMass;
            MaxMass = maxMass;
            MinBR = minBR;
            MaxBR = maxBR;
            MinDB = minDB;
            MaxDB = maxDB;
            MinOZh = minOZh;
            MaxOZh = maxOZh;
            MinDGK = minDGK;
            MaxDGK = maxDGK;
        }

        internal static void AddDefault()
        {
            string[] values;
            var filePC = $"{Environment.CurrentDirectory}/data/{ConfigurationManager.AppSettings["PercentileCorridorsFileName"]}";
            using (var sr = new StreamReader(filePC))
            {
                while (!sr.EndOfStream)
                {

                }
                values = sr.ReadLine().Split(',');
            }
            using (var db = new TemplateApplicationContext())
            {
                db.TemplateValues.Add(new PercentileCorridors(12, 13, 25, 22, 24, 7, 11, 50, 71, 21, 25));
                db.SaveChanges();
            }
        }
    }
}
