using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using System;
using System.Linq;

namespace MaternityHospital.Services
{
    class Transperinealnoe : IRepository
    {
        public int Id { get; set; }
        public string? RaskrMatochnogoZeva { get; set; }
        public string? RastoanieHPD { get; set; }
        public string? YgolMLA { get; set; }
        public int VisitId { get; set; }

        public Transperinealnoe(string raskrMatochnogoZeva, string rastoanieHPD, string ygolMLA, int visitId)
        {
            RaskrMatochnogoZeva = raskrMatochnogoZeva;
            RastoanieHPD = rastoanieHPD;
            YgolMLA = ygolMLA;
            VisitId = visitId;
        }

        public Transperinealnoe()
        {
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.transperinealnoe.First(c => c.VisitId == visitId);
                Id = temp.Id;
                RaskrMatochnogoZeva = temp.RaskrMatochnogoZeva;
                RastoanieHPD = temp.RastoanieHPD;
                YgolMLA = temp.YgolMLA;
                VisitId = visitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.transperinealnoe.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.transperinealnoe.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.transperinealnoe.Remove(this);
                db.SaveChanges();
            }
        }

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(Transperinealnoe).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
