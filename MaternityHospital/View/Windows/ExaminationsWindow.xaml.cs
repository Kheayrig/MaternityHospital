using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Documents;
using MaternityHospital.DB.Models;
using MaternityHospital.DB.Models.ViewClasses;
using MaternityHospital.DB.Repositories;
using MaternityHospital.Services;
using MaternityHospital.View.Trimesters;

namespace MaternityHospital.View.Windows
{
    public partial class Examinations : Window
    {
        List<IRepository> list;
        public Examinations()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
            currentDoctor.Content = AppSettings.CustomSettings.CurrentDoctor;
            list = AppSettings.WindowsList;
            GoToNext();
        }

        private void GoToNext()
        {
            var trimester = AppSettings.CurrentPatient.Trimester;
            AppSettings.CurrentVisit = new Visit(AppSettings.CurrentPatient, DateTime.Today, trimester, AppSettings.CustomSettings.CurrentDoctor);
            try
            {
                var visit = AppSettings.CurrentVisit;
                visit.GetBy(AppSettings.CurrentPatient.Id);
                if(visit.Trimester == AppSettings.CurrentPatient.Trimester) AppSettings.isUpdating = true;
                else AppSettings.isUpdating = false;
            }
            catch(Exception ex)
            {
                AppSettings.isUpdating = false;
            }
            finally
            {
                GoToCreate(trimester);
                if (AppSettings.isUpdating) GoToUpdate(trimester);
                OpenNext(trimester);
            }

        }

        private void OpenNext(int trimester)
        {
            switch (trimester)
            {
                case 1:
                    Tabs.Content = new Trimester1();
                    Title = "1-ый триместр";
                    break;
                case 2:
                    Tabs.Content = new Trimester2();
                    Title = "2-ый триместр";
                    break;
                case 3:
                    Tabs.Content = new Trimester3();
                    Title = "3-ый триместр";
                    break;
                case 4:
                    Tabs.Content = new Childbirth();
                    Title = "Роды";
                    break;
            }
        }

        private void GoToCreate(int trimester)
        {
            var visit = AppSettings.CurrentVisit;
            switch (trimester)
            {
                case 1:
                    list.Add(new MalSroki());
                    break;
                case 2:
                    list.Add(new Obschiesvedenia());
                    list.Add(new Fetometria());
                    list.Add(new RasshirennOsmotr());
                    break;
                case 3:
                    list.Add(new Obschiesvedenia());
                    list.Add(new Fetometria());
                    list.Add(new RasshirennOsmotr());
                    list.Add(new Dopplerometria());
                    break;
                case 4:
                    list.Add(new Obschiesvedenia());
                    list.Add(new Fetometria());
                    list.Add(new Dopplerometria());
                    list.Add(new Translabialnoe());
                    list.Add(new Transperinealnoe());
                    break;
            }
        }

        private void GoToUpdate(int trimester)
        {
            int patientId = AppSettings.CurrentPatient.Id;
            try
            {
                foreach(var item in list)
                {
                    item.GetBy(patientId);
                }
            }
            catch(Exception ex)
            {
                Error();
            }
        }

        private void Error()
        {
            MessageBox.Show("Что-то пошло не так, не удалось загрузить информацию о пациентке");
            Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            AppSettings.isUpdating = false;
            AppSettings.WindowsList.Clear();
        }

        private void createPatientButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new ChangeDoctor();
            if (win.ShowDialog() == true)
            {
                currentDoctor.Content = AppSettings.CustomSettings.CurrentDoctor;
            }
        }
    }
}