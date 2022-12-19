using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models.ExtraViewClasses
{
    class AbdominalCavity
    {
        public int Id { get; set; }
        public string PerBrStenka { get; set; }
        public string Pechen { get; set; }
        public string zheloPyz1 { get; set; } = "расположен типично";
        public string zheloPyz2 { get; set; } = "без особенностей";
        public string Selizionka { get; set; }
        public string Zhelydok { get; set; }
        public string Kichetschnik { get; set; }
        public string Potschki1 { get; set; }
        public string Potschki2 { get; set; }
        public string MPyzyr { get; set; }
        public string OObrazovania { get; set; }
        public string Ascit { get; set; }
        public int VisitId { get; set; }

        public AbdominalCavity(int id, string perBrStenka, string pechen, string zheloPyz1, string zheloPyz2, string selizionka, string zhelydok, string kichetschnik, string potschki1, string potschki2, string mPyzyr, string oObrazovania, string ascit, int visitId)
        {
            Id = id;
            PerBrStenka = perBrStenka;
            Pechen = pechen;
            this.zheloPyz1 = zheloPyz1;
            this.zheloPyz2 = zheloPyz2;
            Selizionka = selizionka;
            Zhelydok = zhelydok;
            Kichetschnik = kichetschnik;
            Potschki1 = potschki1;
            Potschki2 = potschki2;
            MPyzyr = mPyzyr;
            OObrazovania = oObrazovania;
            Ascit = ascit;
            VisitId = visitId;
        }

        public AbdominalCavity(Visit visit)
        {
            VisitId = visit.Id;
        }
    }
}
