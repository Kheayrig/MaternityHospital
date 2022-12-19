using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Translabialnoe : IViewRepository
    {
        public int Id { get; set; }
        public int DlinaCHeKanala { get; set; }
        public string PlodnyeObolochki { get; set; } = "визуализируется";
        public int RastoanieHSD { get; set; }
        public int RastoaniePD { get; set; }
        public Visit? VisitId { get; set; }

        public Translabialnoe(int id, int dlinaCHeKanala, string plodnyeObolochki, int rastoanieHSD, int rastoaniePD, Visit? visitId)
        {
            Id = id;
            DlinaCHeKanala = dlinaCHeKanala;
            PlodnyeObolochki = plodnyeObolochki;
            RastoanieHSD = rastoanieHSD;
            RastoaniePD = rastoaniePD;
            VisitId = visitId;
        }

        public Translabialnoe(Visit? visit)
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
