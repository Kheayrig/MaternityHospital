using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class RasshirennOsmotr : IRepository
    {
        public int Id { get; set; }
        public string? placenta { get; set; } = "перекрывает внутренний зев";
        public string? PPoverxnost { get; set; } = "нормальная";
        public string? stryctyra { get; set; } = "однородная";
        public string? kolVod { get; set; } = "нормальное";
        public string? StepenZrelosti { get; set; } = "1";
        public string? vish { get; set; }
        public int VisitId { get; set; }

        public RasshirennOsmotr(string placenta, string pPoverxnost, string stryctyra, string kolVod, string stepenZrelosti, string vish, int visitId)
        {
            this.placenta = placenta;
            PPoverxnost = pPoverxnost;
            this.stryctyra = stryctyra;
            this.kolVod = kolVod;
            StepenZrelosti = stepenZrelosti;
            this.vish = vish;
            VisitId = visitId;
        }

        public RasshirennOsmotr()
        {
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.rasshirennOsmotr.First(c => c.VisitId == visitId);
                Id = temp.Id;
                placenta = temp.placenta;
                PPoverxnost = temp.PPoverxnost;
                stryctyra = temp.stryctyra;
                kolVod = temp.kolVod;
                StepenZrelosti = temp.StepenZrelosti;
                vish = temp.vish;
                VisitId = visitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.rasshirennOsmotr.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.rasshirennOsmotr.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.rasshirennOsmotr.Remove(this);
                db.SaveChanges();
            }
        }

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(RasshirennOsmotr).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
