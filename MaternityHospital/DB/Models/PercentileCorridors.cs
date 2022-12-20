using Microsoft.EntityFrameworkCore;
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
    internal enum PercentileCorridorsField
    {
        Mass,
        BR,
        DB,
        OZh,
        DGK
    }
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

        internal static int GetWeekBy(int value, PercentileCorridorsField field)
        {
            using(var db = new TemplateApplicationContext())
            {
                var str = db.TemplateValues
                    .FromSqlRaw($"SELECT * FROM TemplateValues WHERE Min{field}<={value} AND Max{field}>={value}")
                    .Last();
                return str.Week;
            }
        }

        internal static void AddDefault()
        {
            string[] data;
            var filePC = $"{Environment.CurrentDirectory}/{ConfigurationManager.AppSettings["PercentileCorridorsFileName"]}";
            using (var sr = new StreamReader(filePC))
            {
                data = sr.ReadToEnd().Split(new char[] { '\n' , '\t'}, StringSplitOptions.RemoveEmptyEntries);
            }
            using (var db = new TemplateApplicationContext())
            {
                foreach (var item in data)
                {
                    var values = item.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                    db.TemplateValues.Add(new PercentileCorridors(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10]));
                }
                db.SaveChanges();
            }
        }
    }
}
