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
        public int DlinaCHeKanala { get; set; }
        public string PlodnyeObolochki { get; set; } = "визуализируется";
        public int RastoanieHSD { get; set; }
        public int RastoaniePD { get; set; }
        public int VisitId { get; set; }

        public Translabialnoe(int id, int dlinaCHeKanala, string plodnyeObolochki, int rastoanieHSD, int rastoaniePD, int visitId)
        {
            Id = id;
            DlinaCHeKanala = dlinaCHeKanala;
            PlodnyeObolochki = plodnyeObolochki;
            RastoanieHSD = rastoanieHSD;
            RastoaniePD = rastoaniePD;
            VisitId = visitId;
        }

        public Translabialnoe(Visit visit)
        {
            VisitId = visit.Id;
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
    }
}
