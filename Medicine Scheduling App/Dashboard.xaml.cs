﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Medicine_Scheduling_App
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnModules_Click(object sender, RoutedEventArgs e)
        {
            ManageModules modules = new ManageModules();
            frmMain.Navigate(modules);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
           //mainWindow.Show();
            this.Close();
        }

        private void btnTimetables_Click(object sender, RoutedEventArgs e)
        {
            ViewTimetables timetables = new ViewTimetables();
            frmMain.Navigate(timetables);
        }

    }
}

