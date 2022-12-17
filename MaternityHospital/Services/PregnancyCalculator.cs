using MaternityHospital.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    public class PregnancyCalculator : IPregnancyCalculator
    {
        protected int PregnancyDuration { get; }
        protected DateTime? LastPeriodDate { get; }
        protected DateTime FirstScanDate { get; }

        public PregnancyCalculator(DateTime? lastPeriodDate, DateTime firstScanDate, int pregnancyDuration = 0)
        {
            LastPeriodDate = lastPeriodDate;
            FirstScanDate = firstScanDate;
            PregnancyDuration = pregnancyDuration;
        }

        public int Calculate()
        {
            if(LastPeriodDate == null)
            {
                return ScanCalculate();
            }
            return PeriodCalculate();
        }
        private int ScanCalculate()
        {
            return (DateTime.Now - FirstScanDate).Days/7 + PregnancyDuration;
        }
        private int PeriodCalculate()
        {
            return (DateTime.Now - LastPeriodDate).Value.Days/7 + PregnancyDuration;
        }
        public int GetTrimester()
        {
            if (PregnancyDuration < 18) return 1;
            else if (PregnancyDuration < 30) return 2;
            else if (PregnancyDuration < 35) return 3;
            else return 4;
        }
    }
}
