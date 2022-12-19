using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaternityHospital.Services;

namespace MaternityHospital.DB.Models.ExtraViewClasses
{
    public class HeartVM : IViewRepository
    {
        public int Id { get; set; }
        public string KamSerdca { get; set; }
        public string MPP { get; set; }
        public string MZHP { get; set; }
        public string MagArterii { get; set; }
        public string Aorta1 { get; set; } = "левая";
        public string Aorta2 { get; set; }
        public string Aorta3 { get; set; }
        public string LegStvol1 { get; set; }
        public string LegStvol2 { get; set; }
        public string LegArterii { get; set; }
        public string ArterPotok1 { get; set; } = "от левой легочной артерии";
        public string ArterPotok2 { get; set; } = "расположен обычно";
        public string VPV1 { get; set; } = "справа от аорты";
        public string VPV2 { get; set; } = "в правое предсердие";
        public string NVP1 { get; set; } = "недилатирована";
        public string NVP2 { get; set; } = "в правом предсердие";
        public string NVP3 { get; set; } = "визуализируется";
        public string NeparVena1 { get; set; } = "визуализируется";
        public string NeparVena2 { get; set; } = "недилатирована";
        public string LegVeny { get; set; }
        public string Gidroperekard { get; set; }
        public Visit? VisitId { get; set; }

        public HeartVM(Visit? visit)
        {
            VisitId = visit;
        }

        public HeartVM(int id, string kamSerdca, string mPP, string mZHP, string magArterii, string aorta1, string aorta2, string aorta3, string legStvol1, string legStvol2, string legArterii, string arterPotok1, string arterPotok2, string vPV1, string vPV2, string nVP1, string nVP2, string nVP3, string neparVena1, string neparVena2, string legVeny, string gidroperekard, Visit? visitId)
        {
            Id = id;
            KamSerdca = kamSerdca;
            MPP = mPP;
            MZHP = mZHP;
            MagArterii = magArterii;
            Aorta1 = aorta1;
            Aorta2 = aorta2;
            Aorta3 = aorta3;
            LegStvol1 = legStvol1;
            LegStvol2 = legStvol2;
            LegArterii = legArterii;
            ArterPotok1 = arterPotok1;
            ArterPotok2 = arterPotok2;
            VPV1 = vPV1;
            VPV2 = vPV2;
            NVP1 = nVP1;
            NVP2 = nVP2;
            NVP3 = nVP3;
            NeparVena1 = neparVena1;
            NeparVena2 = neparVena2;
            LegVeny = legVeny;
            Gidroperekard = gidroperekard;
            VisitId = visitId;
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
