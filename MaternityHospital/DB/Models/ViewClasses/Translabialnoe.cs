using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Translabialnoe : IRepository
    {
        public int Id { get; set; }
        public string? DlinaCHeKanala { get; set; }
        public string? PlodnyeObolochki { get; set; } = "визуализируется";
        public string? RastoanieHSD { get; set; }
        public string? RastoaniePD { get; set; }
        public int VisitId { get; set; }

        public Translabialnoe(string dlinaCHeKanala, string plodnyeObolochki, string rastoanieHSD, string rastoaniePD, int visitId)
        {
            DlinaCHeKanala = dlinaCHeKanala;
            PlodnyeObolochki = plodnyeObolochki;
            RastoanieHSD = rastoanieHSD;
            RastoaniePD = rastoaniePD;
            VisitId = visitId;
        }

        public Translabialnoe()
        {
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.translabialnoe.First(c => c.VisitId == visitId);
                Id = temp.Id;
                DlinaCHeKanala = temp.DlinaCHeKanala;
                PlodnyeObolochki = temp.PlodnyeObolochki;
                RastoanieHSD = temp.RastoanieHSD;
                RastoaniePD = temp.RastoaniePD;
                VisitId = visitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.translabialnoe.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.translabialnoe.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.translabialnoe.Remove(this);
                db.SaveChanges();
            }
        }

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(Translabialnoe).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
