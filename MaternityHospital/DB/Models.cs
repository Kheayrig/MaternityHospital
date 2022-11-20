using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MaternityHospital.DB
{
    public class Patient
    {
        public int Id { get; set; }
        public string? FIO { get; set; }
        public DateTime BirthDate { get; set; }
        public Patient(string? fIO, DateTime birthDate)
        {
            FIO = fIO;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"{FIO} {BirthDate}";
        }
    }
}
