using DBLibrary;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Medicine_Scheduling_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchedulingDBEntities db = new SchedulingDBEntities("metadata=res://*/SchedulingModel.csdl|res://*/SchedulingModel.ssdl|res://*/SchedulingModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.1.1;initial catalog=SchedulingDB;persist security info=True;user id=Lynsey;password=ogu3Yapi;pooling=False;MultipleActiveResultSets=True;App=EntityFramework'");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            string currentUser = tbxUsername.Text;
            string currentPassword = tbxPassword.Password;

            foreach (var user in db.users)
            {
                if (user.username == currentUser && user.pass == currentPassword)
                {
                    MessageBox.Show("User authenticated");
                    Dashboard dashboard = new Dashboard();
                    dashboard.user = user;
                    dashboard.ShowDialog();
                }
                else
                {
                    lblErrorMessage.Content = "Please check your username and password";
                }
            }
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
