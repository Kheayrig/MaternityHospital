using MaternityHospital.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MaternityHospital.Services
{
    public class PregnancyCalculator : IPregnancyCalculator
    {
        protected int PregnancyDurationWeek { get; set; }
        protected int PregnancyDurationDay { get; set; }
        protected DateTime? LastPeriodDate { get; }

        public PregnancyCalculator(DateTime? lastPeriodDate, int pregnancyDurationWeek = 0, int pregnancyDurationDay = 0)
        {
            LastPeriodDate = lastPeriodDate;
            PregnancyDurationWeek = pregnancyDurationWeek;
            PregnancyDurationDay= pregnancyDurationDay;
        }

        private int ScanCalculate(bool isWeek = true)
        {
            int days = PregnancyDurationDay + PregnancyDurationWeek * 7;
            var actual = DateTime.Now.AddDays(-days).Day;
            if (isWeek) actual /= 7;
            else actual %= 7;
            return actual;

        }
        private int PeriodCalculate(bool isWeek = true)
        {
            int actual = (DateTime.Now - LastPeriodDate).Value.Days;
            if (isWeek) actual = actual / 7;
            else actual = actual % 7;
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
