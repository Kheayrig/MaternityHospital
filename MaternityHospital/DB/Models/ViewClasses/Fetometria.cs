using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Fetometria : IViewRepository
    {
        public int Id { get; set; }
        public int  BR { get; set; }
        public int DBK { get; set; }
        public int OJ { get; set; }
        public int  Mass { get; set; }
        public Visit? VisitId { get; set; }

        public Fetometria(int id, int bR, int dBK, int oJ, int mass, Visit? visitId)
        {
            Id = id;
            BR = bR;
            DBK = dBK;
            OJ = oJ;
            Mass = mass;
            VisitId = visitId;
        }

        public Fetometria(Visit? visit)
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
