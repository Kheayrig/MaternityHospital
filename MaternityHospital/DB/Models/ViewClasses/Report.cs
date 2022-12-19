using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services.ViewClasses
{
    internal class Report : IViewRepository
    {
        public int Id { get; set; }
        public string ReportInfo { get; set; }
        public Visit? VisitId { get; set; }

        public Report(int id, string reportInfo, Visit? visitId)
        {
            Id = id;
            ReportInfo = reportInfo;
            VisitId = visitId;
        }

        public Report(Visit? visit)
        {
            VisitId = visit;
        }

        public void GetFromDB()
        {
            throw new NotImplementedException();
        }

        public void SendToDB()
        {
            throw new NotImplementedException();
        }
    }
}
