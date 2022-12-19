using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models.ExtraViewClasses
{
    class CnsFaceNeck
    {
        public int Id { get; set; }
        public string Lico { get; set; }
        public string BokZhelydochki { get; set; }
        public string PPPeregorodki { get; set; } = "норма";
        public string TZhelydochek { get; set; }
        public string CHZhelydochek { get; set; }
        public string Talamys { get; set; } = "разделенный";
        public string BCisterna { get; set; }
        public Visit? VisitId { get; set; }

        public CnsFaceNeck(Visit? visit)
        {
            VisitId = visit;
        }

        public CnsFaceNeck(int id, string lico, string bokZhelydochki, string pPPeregorodki, string tZhelydochek, string cHZhelydochek, string talamys, string bCisterna, Visit? visitId)
        {
            Id = id;
            Lico = lico;
            BokZhelydochki = bokZhelydochki;
            PPPeregorodki = pPPeregorodki;
            TZhelydochek = tZhelydochek;
            CHZhelydochek = cHZhelydochek;
            Talamys = talamys;
            BCisterna = bCisterna;
            VisitId = visitId;
        }
    }
}
