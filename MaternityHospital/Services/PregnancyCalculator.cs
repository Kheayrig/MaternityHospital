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
        protected int PregnancyDurationWeek { get; set; }
        protected int PregnancyDurationDay { get; set; }
        protected DateTime? LastPeriodDate { get; }
        protected DateTime FirstScanDate { get; }

        public PregnancyCalculator(DateTime? lastPeriodDate, DateTime firstScanDate, int pregnancyDurationWeek = 0, int pregnancyDurationDay = 0)
        {
            LastPeriodDate = lastPeriodDate;
            FirstScanDate = firstScanDate;
            PregnancyDurationWeek = pregnancyDurationWeek;
            PregnancyDurationDay= pregnancyDurationDay;
        }

        private int ScanCalculate(bool isWeek = true)
        {
            int actual = (DateTime.Now - FirstScanDate).Days + PregnancyDurationDay;
            if (isWeek) actual = actual / 7 + PregnancyDurationWeek;
            return actual;

        }
        private int PeriodCalculate(bool isWeek = true)
        {
            int actual = (DateTime.Now - LastPeriodDate).Value.Days + PregnancyDurationDay;
            if (isWeek) actual = actual / 7 + PregnancyDurationWeek;
            return actual;
        }
        public int GetTrimester()
        {
            if (PregnancyDurationWeek < 18) return 1;
            if (PregnancyDurationWeek < 30) return 2;
            if (PregnancyDurationWeek < 35) return 3;
            return 4;
        }

        public int GetPregnancyDurationWeek()
        {
            int duration;
            if (LastPeriodDate == null)
            {
                duration = ScanCalculate(true);
            }
            else duration = PeriodCalculate(true);
            PregnancyDurationWeek = duration;
            return duration;
        }

        public int GetPregnancyDurationDay()
        {
            int duration;
            if (LastPeriodDate == null)
            {
                duration = ScanCalculate(false);
            }
            else duration = PeriodCalculate(false);
            PregnancyDurationDay = duration;
            return duration;
        }
    }
}
