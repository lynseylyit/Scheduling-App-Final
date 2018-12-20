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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Dashboard : Window
    {

        public Dashboard()
        {
            InitializeComponent();
        }
        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            ViewTimetablesOne viewTimetable = new ViewTimetablesOne();
            viewTimetable.ShowDialog();
        }
        private void btnModules_Click(object sender, RoutedEventArgs e)
        {
            ManageModules modules = new ManageModules();
            modules.ShowDialog();
        }
    }
}
