using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models.ExtraViewClasses
{
    class Chestcavity
    {
        public int Id { get; set; }
        public string PSerdca { get; set; }
        public string ExoLegkix { get; set; }
        public string OObrazovanua { get; set; }
        public string Gidrotoraks { get; set; }
        public string TOtnochenie1 { get; set; }
        public string TOtnochenie2 { get; set; }
        public Visit? VisitId { get; set; }

        public Chestcavity(Visit? visit)
        {
            VisitId = visit;
        }

        public Chestcavity(int id, string pSerdca, string exoLegkix, string oObrazovanua, string gidrotoraks, string tOtnochenie1, string tOtnochenie2, Visit? visitId)
        {
            Id = id;
            PSerdca = pSerdca;
            ExoLegkix = exoLegkix;
            OObrazovanua = oObrazovanua;
            Gidrotoraks = gidrotoraks;
            TOtnochenie1 = tOtnochenie1;
            TOtnochenie2 = tOtnochenie2;
            VisitId = visitId;
        }
    }
}
