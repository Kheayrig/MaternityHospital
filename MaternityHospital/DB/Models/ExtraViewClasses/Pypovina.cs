using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models.ExtraViewClasses
{
    class Pypovina
    {
        public int Id { get; set; }
        public string PypochnVena1 { get; set; } = "левая";
        public string PypochnVena2 { get; set; } = "в портальный синус";
        public string PypochnVena3 { get; set; } = "не расширена";
        public string Precreplenie { get; set; } = "центральное";
        public string PypART { get; set; } = "две";
        public string SosydPyp { get; set; } = "три";
        public int VisitId { get; set; }

        public Pypovina(int id, string pypochnVena1, string pypochnVena2, string pypochnVena3, string precreplenie, string pypART, string sosydPyp, int visitId)
        {
            Id = id;
            PypochnVena1 = pypochnVena1;
            PypochnVena2 = pypochnVena2;
            PypochnVena3 = pypochnVena3;
            Precreplenie = precreplenie;
            PypART = pypART;
            SosydPyp = sosydPyp;
            VisitId = visitId;
        }

        public Pypovina(Visit visit)
        {
            VisitId = visit.Id;
        }

    }
}
