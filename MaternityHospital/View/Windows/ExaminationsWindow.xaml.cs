using System;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Documents;
using MaternityHospital.DB.Models;
using MaternityHospital.DB.Models.ViewClasses;
using MaternityHospital.Services;
using MaternityHospital.View.Trimesters;

namespace MaternityHospital.View.Windows
{
    public partial class Examinations : Window
    {
        public Examinations()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            currentDoctor.Content = AppSettings.CustomSettings.CurrentDoctor;
            var trimester = AppSettings.CurrentPatient.Trimester;
            var list = AppSettings.WindowsList;
            AppSettings.CurrentVisit = new Visit(AppSettings.CurrentPatient, DateTime.Today, trimester, AppSettings.CustomSettings.CurrentDoctor);

            switch (trimester)
            {
                case 1:
                    list.Add(new MalSroki(AppSettings.CurrentVisit));
                    Tabs.Content = new Trimester1();
                    break;
                case 2:
                    list.Add(new Obschiesvedenia(AppSettings.CurrentVisit));
                    list.Add(new Fetometria(AppSettings.CurrentVisit));
                    list.Add(new RasshirennOsmotr(AppSettings.CurrentVisit));
                    Tabs.Content = new Trimester2();
                    break;
                case 3:
                    list.Add(new Obschiesvedenia(AppSettings.CurrentVisit));
                    list.Add(new Fetometria(AppSettings.CurrentVisit));
                    list.Add(new RasshirennOsmotr(AppSettings.CurrentVisit));
                    list.Add(new Dopplerometria(AppSettings.CurrentVisit));
                    Tabs.Content = new Trimester3();
                    break;
                case 4:
                    list.Add(new Obschiesvedenia(AppSettings.CurrentVisit));
                    list.Add(new Fetometria(AppSettings.CurrentVisit));
                    list.Add(new Dopplerometria(AppSettings.CurrentVisit));
                    list.Add(new Translabialnoe(AppSettings.CurrentVisit));
                    list.Add(new Transperinealnoe(AppSettings.CurrentVisit));
                    Tabs.Content = new Childbirth();
                    break;
            }
        } 
    }
}