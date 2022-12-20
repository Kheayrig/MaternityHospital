using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Fetometria : IRepository
    {
        public int Id { get; set; }
        public string  BR { get; set; }
        public string DBK { get; set; }
        public string OJ { get; set; }
        public string Mass { get; set; }
        public int VisitId { get; set; }

        public Fetometria(string bR, string dBK, string oJ, string mass, int visitId)
        {
            BR = bR;
            DBK = dBK;
            OJ = oJ;
            Mass = mass;
            VisitId = visitId;
        }

        public Fetometria()
        {
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.fetometria.First(c => c.VisitId == visitId);
                Id = temp.Id;
                BR = temp.BR;
                DBK = temp.DBK;
                OJ = temp.OJ;
                Mass = temp.Mass;
                VisitId = temp.VisitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.fetometria.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.fetometria.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.fetometria.Remove(this);
                db.SaveChanges();
            }
        }

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(Fetometria).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
