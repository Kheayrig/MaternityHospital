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
        public string? ArterPypovinyPI { get; set; }
        public string? ArterPypovinySrok { get; set; }
        public string? ArterPypovinyMass { get; set; }
        public string? CMozgPI { get; set; }
        public string? CMozgSrok { get; set; }
        public string? CMozgMass { get; set; }
        public string? MCAPI { get; set; }
        public string? MCASrok { get; set; }
        public string? MCAMass { get; set; }
        public string? DiagKonyga { get; set; }
        public int VisitId { get; set; }

        public Dopplerometria(int id, string arterPypovinyPI, string arterPypovinySrok, string arterPypovinyMass, string cMozgPI, string cMozgSrok, string cMozgMass, string mCAPI, string mCASrok, string mCAMass, string diagKonyga, int visitId)
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

        public Dopplerometria()
        {

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

        public void ChangeProperty(string name, object? value)
        {
            var pr = typeof(Dopplerometria).GetProperty(name);
            pr.SetValue(this, value);
        }
    }
}
