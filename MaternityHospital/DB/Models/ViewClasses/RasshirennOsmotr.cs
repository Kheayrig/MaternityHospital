using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class RasshirennOsmotr : IViewRepository
    {
        public int Id { get; set; }
        public string placenta { get; set; } = "перекрывает внутренний зев";
        public string PPoverxnost { get; set; } = "нормальная";
        public string stryctyra { get; set; } = "однородная";
        public string kolVod { get; set; } = "нормальное";
        public string StepenZrelosti { get; set; } = "1";
        public int vish { get; set; }
        public Visit? VisitId { get; set; }

        public RasshirennOsmotr(int id, string placenta, string pPoverxnost, string stryctyra, string kolVod, string stepenZrelosti, int vish, Visit? visitId)
        {
            Id = id;
            this.placenta = placenta;
            PPoverxnost = pPoverxnost;
            this.stryctyra = stryctyra;
            this.kolVod = kolVod;
            StepenZrelosti = stepenZrelosti;
            this.vish = vish;
            VisitId = visitId;
        }

        public RasshirennOsmotr(Visit? visit)
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
