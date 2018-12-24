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
    /// Interaction logic for ManageModules.xaml
    /// </summary>
    public partial class ManageModules : Page
    {
        public ManageModules()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("mysqlconnection");
                DataSet ds;
                SqlDataAdapter da;
                SqlCommandBuilder scb;
                DataTable dt;

                da = new SqlDataAdapter("SELECT * FROM [table] WHERE [NameColumn] LIKE '%" + txtSearch.Text + "%'" OR [DateAColumn] LIKE '%" + txtSearch.Text + "%'" OR [TimeAColumn] LIKE '" + txtSearch.Text + "' OR [TimeBColumn] LIKE '" + txtSearch.Text + "' OR [TimeCColumn] LIKE '" + txtSearch.Text + "'", con);
                ds = new DataSet();
                dt = new DataTable();
                ds.Clear();
                da.Fill(dt);
                searchedList.ItemsSource = dt.DefaultView;

                con.Open();
                con.Close();
            }
            catch
            {
                return;
            }

        }
    }
}
