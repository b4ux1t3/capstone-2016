using System;
using System.Collections.Generic;
using System.Data;
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

namespace capstone
{
    /// <summary>
    /// Interaction logic for ReportingHome.xaml
    /// </summary>
    public partial class ReportingHome : Window
    {
        internal Main HomeWindow;

        public ReportingHome(Main main)
        {
            InitializeComponent();
            this.HomeWindow = main;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }

        private void Patients_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM patients;";

            DataTable data = HomeWindow.Connector.SendQuery(query);

            DBReport report = new DBReport(HomeWindow, this, data);
        }

        private void Treatments_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM treatments;";

            DataTable data = HomeWindow.Connector.SendQuery(query);

            DBReport report = new DBReport(HomeWindow, this, data);
        }

        private void StaffSchedule_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM staffAvailability;";

            DataTable data = HomeWindow.Connector.SendQuery(query);

            DBReport report = new DBReport(HomeWindow, this, data);
        }
    }
}
