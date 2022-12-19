using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MaternityHospital.DB.Models
{
    public class Doctor
    {
        [Key]
        public string FIO { get; set; }

        public Doctor(string fIO)
        {
            FIO = fIO;
        }

        public static BindingList<Doctor> GetAllTableView()
        {
            using (var db = new ApplicationContext())
            {
                db.Doctors.Load();
                return db.Doctors.Local.ToBindingList();
            }
        }
        public void Add()
        {
            using (var db = new ApplicationContext())
            {
                db.Doctors.Add(this);
                db.SaveChanges();
            }
        }
        public void Delete()
        {
            using (var db = new ApplicationContext())
            {
                db.Doctors.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
