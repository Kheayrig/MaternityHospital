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
        public int  BR { get; set; }
        public int DBK { get; set; }
        public int OJ { get; set; }
        public int  Mass { get; set; }
        public int VisitId { get; set; }

        public Fetometria(int id, int bR, int dBK, int oJ, int mass, int visitId)
        {
            Id = id;
            BR = bR;
            DBK = dBK;
            OJ = oJ;
            Mass = mass;
            VisitId = visitId;
        }

        public Fetometria(Visit visit)
        {
            VisitId = visit.Id;
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
    }
}
