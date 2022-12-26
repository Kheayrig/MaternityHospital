using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services.ViewClasses
{
    internal class Report : IRepository
    {
        public int Id { get; set; }
        public string? ReportInfo { get; set; }
        public int VisitId { get; set; }

        public Report(string reportInfo, int visitId)
        {
            ReportInfo = reportInfo;
            VisitId = visitId;
        }

        public Report()
        {
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.reports.First(c => c.VisitId == visitId);
                Id = temp.Id;
                ReportInfo = temp.ReportInfo;
                VisitId = temp.VisitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.reports.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.reports.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.reports.Remove(this);
                db.SaveChanges();
            }
        }

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(Report).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
