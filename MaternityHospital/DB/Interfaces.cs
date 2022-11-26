using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MaternityHospital.DB
{
    public interface IRepository<T>
    {
        void Add();
        void Update();
        void Delete();
    }
}
