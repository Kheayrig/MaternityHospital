using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaternityHospital.Services
{
    public class PregnancyCalculator : IPregnancyCalculator
    {
        protected double PregnancyDuration { get; }
        protected DateTime? LastPeriodDate { get; }
        protected DateTime FirstScanDate { get; }

        public PregnancyCalculator(DateTime? lastPeriodDate, DateTime firstScanDate, double pregnancyDuration = 0)
        {
            LastPeriodDate = lastPeriodDate;
            FirstScanDate = firstScanDate;
            PregnancyDuration = pregnancyDuration;
        }

        public double Calculate()
        {
            if(LastPeriodDate == null)
            {
                return ScanCalculate();
            }
            return PeriodCalculate();
        }
        private double ScanCalculate()
        {
            return (DateTime.Now - FirstScanDate).Days/7 + PregnancyDuration;
        }
        private double PeriodCalculate()
        {
            return (DateTime.Now - LastPeriodDate).Value.Days/7 + PregnancyDuration;
        }
    }
}
