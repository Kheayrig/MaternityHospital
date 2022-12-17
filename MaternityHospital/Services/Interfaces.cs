using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MaternityHospital.Services
{
    public interface IRepository<T>
    {
        void Add();
        void Update();
        void Delete();
    }
    public interface IViewRepository
    {
        void SendToDB();
        void GetFromDB();
    }
    public interface IPregnancyCalculator
    {
        int Calculate();
    }
}
