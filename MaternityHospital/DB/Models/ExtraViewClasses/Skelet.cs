using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models.ExtraViewClasses
{
    internal class Skelet
    {
        public int Id { get; set; }
        public string Pozvonochnik { get; set; } = "без дефектов";
        public string BolBer { get; set; } = "норма";
        public string MalBer { get; set; } = "норма";
        public string LOktKosti { get; set; } = "норма";
        public string LychevKost { get; set; } = "норма";
        public string Kisti { get; set; } = "норма";
        public string Stopi { get; set; } = "норма";
        public Visit? VisitId { get; set; }

        public Skelet(int id, string pozvonochnik, string bolBer, string malBer, string lOktKosti, string lychevKost, string kisti, string stopi, Visit? visitId)
        {
            Id = id;
            Pozvonochnik = pozvonochnik;
            BolBer = bolBer;
            MalBer = malBer;
            LOktKosti = lOktKosti;
            LychevKost = lychevKost;
            Kisti = kisti;
            Stopi = stopi;
            VisitId = visitId;
        }

        public Skelet(Visit? visit)
        {
            VisitId = visit;
        }


    }
}
