using MaternityHospital.DB.Models;
using System;

namespace MaternityHospital.Services
{
    class Transperinealnoe : IViewRepository
    {
        public int Id { get; set; }
        public int RaskrMatochnogoZeva { get; set; }
        public int RastoanieHPD { get; set; }
        public int YgolMLA { get; set; }
        public Visit? VisitId { get; set; }

        public Transperinealnoe(int id, int raskrMatochnogoZeva, int rastoanieHPD, int ygolMLA, Visit? visitId)
        {
            Id = id;
            RaskrMatochnogoZeva = raskrMatochnogoZeva;
            RastoanieHPD = rastoanieHPD;
            YgolMLA = ygolMLA;
            VisitId = visitId;
        }

        public Transperinealnoe(Visit? visit)
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
