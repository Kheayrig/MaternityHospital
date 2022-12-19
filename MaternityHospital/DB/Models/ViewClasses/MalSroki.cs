using MaternityHospital.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models.ViewClasses
{
    class MalSroki : IRepository
    {
        public int Id { get; set; }
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

        public int VisitId { get; set; }

        public MalSroki(int id, string razMatki1, string razMatki2, string razMatki3, string yvelichina1, string yvelichina2, string formaMatki, string echostructure1, string srednDiametrPlodAiza1, string srednDiametrPlodAiza2, string kTR1, string kTR2, string serdchbienie, string diamZheltMechka, string lOvary1, string lOvary2, string lOvary3, string lOvary4, string pOvary1, string pOvary2, string pOvary3, string pOvary4, string dopDann, string xirion, int visitId)
        {
            Id = id;
            RazMatki1 = razMatki1;
            RazMatki2 = razMatki2;
            RazMatki3 = razMatki3;
            Yvelichina1 = yvelichina1;
            Yvelichina2 = yvelichina2;
            FormaMatki = formaMatki;
            this.echostructure1 = echostructure1;
            SrednDiametrPlodAiza1 = srednDiametrPlodAiza1;
            SrednDiametrPlodAiza2 = srednDiametrPlodAiza2;
            KTR1 = kTR1;
            KTR2 = kTR2;
            Serdchbienie = serdchbienie;
            DiamZheltMechka = diamZheltMechka;
            LOvary1 = lOvary1;
            LOvary2 = lOvary2;
            LOvary3 = lOvary3;
            LOvary4 = lOvary4;
            POvary1 = pOvary1;
            POvary2 = pOvary2;
            POvary3 = pOvary3;
            POvary4 = pOvary4;
            DopDann = dopDann;
            Xirion = xirion;
            VisitId = visitId;
        }

        public MalSroki(Visit visit)
        {
            VisitId = visit.Id;
        }

        public void GetBy(int visitId)
        {
            using (var db = new ApplicationContext())
            {
                var temp = db.malSroki.First(c => c.VisitId == visitId);
                Id = temp.Id;
                RazMatki1 = temp.RazMatki1;
                RazMatki2 = temp.RazMatki2;
                RazMatki3 = temp.RazMatki3;
                Yvelichina1 = temp.Yvelichina1;
                Yvelichina2 = temp.Yvelichina2;
                FormaMatki = temp.FormaMatki;
                this.echostructure1 = temp.echostructure1;
                SrednDiametrPlodAiza1 = temp.SrednDiametrPlodAiza1;
                SrednDiametrPlodAiza2 = temp.SrednDiametrPlodAiza2;
                KTR1 = temp.KTR1;
                KTR2 = temp.KTR2;
                Serdchbienie = temp.Serdchbienie;
                DiamZheltMechka = temp.DiamZheltMechka;
                LOvary1 = temp.LOvary1;
                LOvary2 = temp.LOvary2;
                LOvary3 = temp.LOvary3;
                LOvary4 = temp.LOvary4;
                POvary1 = temp.POvary1;
                POvary2 = temp.POvary2;
                POvary3 = temp.POvary3;
                POvary4 = temp.POvary4;
                DopDann = temp.DopDann;
                Xirion = temp.Xirion;
                VisitId = visitId;
            }
        }

        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.malSroki.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new ApplicationContext())
            {
                db.malSroki.Update(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.malSroki.Remove(this);
                db.SaveChanges();
            }
        }

    }
}
