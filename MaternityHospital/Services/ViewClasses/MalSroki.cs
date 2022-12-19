using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services.ViewClasses
{
    class MalSroki
    {
        public string RazMatki1 { get; set; }
        public string RazMatki2 { get; set; }
        public string RazMatki3 { get; set; }
        public string Yvelichina1 { get; set; }
        public string Yvelichina2 { get; set; }
        public string FormaMatki { get; set; } = "грушевидная";
        public string echostructure1 { get; set; } = "однородная";
        public string SrednDiametrPlodAiza1 { get; set; }
        public string SrednDiametrPlodAiza2 { get; set; }
        public string KTR1 { get; set; }
        public string KTR2 { get; set; }
        public string Serdchbienie { get; set; } = "есть";
        public string DiamZheltMechka { get; set; }
        public string LOvary1 { get; set; } = "обычной эхоструктуры";
        public string LOvary2 { get; set; }
        public string LOvary3 { get; set; }
        public string LOvary4 { get; set; } = "нормальное";
        public string POvary1 { get; set; } = "обычной эхоструктуры";
        public string POvary2 { get; set; }

        public string POvary3 { get; set; }
        public string POvary4 { get; set; } = "нормальное";

        public string DopDann { get; set; }
        public string Xirion { get; set; } = "передней стенке";

    }
}
