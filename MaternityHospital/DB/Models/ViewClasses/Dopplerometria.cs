using MaternityHospital.DB;
using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Dopplerometria : IRepository
    {
        public int Id { get; set; }
        public int ArterPypovinyPI { get; set; }
        public int ArterPypovinySrok { get; set; }
        public int ArterPypovinyMass { get; set; }
        public int CMozgPI { get; set; }
        public int CMozgSrok { get; set; }
        public int CMozgMass { get; set; }
        public int MCAPI { get; set; }
        public int MCASrok { get; set; }
        public int MCAMass { get; set; }
        public int DiagKonyga { get; set; }
        public int VisitId { get; set; }

        public Dopplerometria(int id, int arterPypovinyPI, int arterPypovinySrok, int arterPypovinyMass, int cMozgPI, int cMozgSrok, int cMozgMass, int mCAPI, int mCASrok, int mCAMass, int diagKonyga, int visitId)
        {
            Id = id;
            ArterPypovinyPI = arterPypovinyPI;
            ArterPypovinySrok = arterPypovinySrok;
            ArterPypovinyMass = arterPypovinyMass;
            CMozgPI = cMozgPI;
            CMozgSrok = cMozgSrok;
            CMozgMass = cMozgMass;
            MCAPI = mCAPI;
            MCASrok = mCASrok;
            MCAMass = mCAMass;
            DiagKonyga = diagKonyga;
            VisitId = visitId;
        }

        public Dopplerometria(Visit visit)
        {
            VisitId = visit.Id;
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                
                var temp = db.dopplerometria.First(c => c.VisitId == visitId);
                Id = temp.Id;
                ArterPypovinyPI = temp.ArterPypovinyPI;
                ArterPypovinySrok = temp.ArterPypovinySrok;
                ArterPypovinyMass = temp.ArterPypovinyMass;
                CMozgPI = temp.CMozgPI;
                CMozgSrok = temp.CMozgSrok;
                CMozgMass = temp.CMozgMass;
                MCAPI = temp.MCAPI;
                MCASrok = temp.MCASrok;
                MCAMass = temp.MCAMass;
                DiagKonyga = temp.DiagKonyga;
                VisitId = temp.VisitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.dopplerometria.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.dopplerometria.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.dopplerometria.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
