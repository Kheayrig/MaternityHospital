using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.DB.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FIO { get; set; }
    }
}
