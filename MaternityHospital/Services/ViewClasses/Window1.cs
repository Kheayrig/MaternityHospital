using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    class Window1: IViewRepository
    {
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

        public void GetFromDB()
        {
            
        }

        public void SendToDB()
        {
            
        }
    }
}
