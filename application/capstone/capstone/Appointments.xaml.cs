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
using System.Windows.Shapes;

namespace capstone
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AppointmentHome : Window
    {
        Main HomeWindow;
        public AppointmentHome(Main sourceWindow)
        {
            InitializeComponent();

            this.HomeWindow = sourceWindow;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            PatientLookup lookup = new PatientLookup(this, HomeWindow);
            lookup.Show();
            this.Hide();
        }

        private void drpDoctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void drpDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void drpTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void winAppointments_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
