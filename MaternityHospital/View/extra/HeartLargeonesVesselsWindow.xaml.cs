﻿using MaternityHospital.Services;
using System.Windows;

namespace MaternityHospital.View.extra
{
    public partial class HeartLargeonesVesselsWindow : Window
    {
        public HeartLargeonesVesselsWindow()
        {
            InitializeComponent();
            FontSize = AppSettings.CustomSettings.CurrentFontSize;
        }
    }
}
