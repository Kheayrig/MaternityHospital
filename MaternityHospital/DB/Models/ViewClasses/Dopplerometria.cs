using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Dopplerometria : IViewRepository
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
        public Visit? VisitId { get; set; }

        public Dopplerometria(int id, int arterPypovinyPI, int arterPypovinySrok, int arterPypovinyMass, int cMozgPI, int cMozgSrok, int cMozgMass, int mCAPI, int mCASrok, int mCAMass, int diagKonyga, Visit? visitId)
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

        public Dopplerometria(Visit? visit)
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
