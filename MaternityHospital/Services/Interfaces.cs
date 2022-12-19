using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MaternityHospital.Services
{
    public interface IRepository
    {
        void Add();
        void Update();
        void Delete();
        void GetBy(int fieldValue);
    }
    public interface IPregnancyCalculator
    {
        int GetPregnancyDurationWeek();
        int GetPregnancyDurationDay();
        int GetTrimester();
    }
}
