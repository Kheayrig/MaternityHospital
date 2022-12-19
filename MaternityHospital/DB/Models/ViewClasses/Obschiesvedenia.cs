using MaternityHospital.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Obschiesvedenia: IViewRepository
    {
        public int Id { get; set; }
        public string plod { get; set; } = "один";
        public string position { get; set; } = "продольное";
        public string predlejanie { get; set; } = "головное";
        public string ritm { get; set; } = "синусовый";
        public string heartbeat { get; set; } = "да";
        public string heartRate { get; set; }
        public string dvijeniye { get; set; } = "да";
        public string dvijeniye_Copy { get; set; } = "&lt; 3 эпизодов";
        public string Breath_movement { get; set; } = "да";
        public string Breath_movement_Copy { get; set; } = "&lt; 30 сек";
        public Visit? VisitId { get; set; }

        public Obschiesvedenia(int id, string plod, string position, string predlejanie, string ritm, string heartbeat, string heartRate, string dvijeniye, string dvijeniye_Copy, string breath_movement, string breath_movement_Copy, Visit? visitId)
        {
            Id = id;
            this.plod = plod;
            this.position = position;
            this.predlejanie = predlejanie;
            this.ritm = ritm;
            this.heartbeat = heartbeat;
            this.heartRate = heartRate;
            this.dvijeniye = dvijeniye;
            this.dvijeniye_Copy = dvijeniye_Copy;
            Breath_movement = breath_movement;
            Breath_movement_Copy = breath_movement_Copy;
            VisitId = visitId;
        }

        public Obschiesvedenia(Visit? visit)
        {
            VisitId = visit;
        }

        public void GetFromDB()
        {
            
        }

        public void SendToDB()
        {
            
        }
    }
}
