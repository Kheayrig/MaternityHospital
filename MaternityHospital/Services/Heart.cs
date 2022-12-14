using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Heart
    {
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
    }
}
