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
    /// Interaction logic for WinHome.xaml
    /// </summary>
    public partial class WinHome : Window
    {
        public WinHome()
        {
            InitializeComponent();
        }

        private void btnPatients_Click(object sender, RoutedEventArgs e)
        {
            PatientHome patient = new PatientHome();
            patient.Show();
            this.Hide();
          
        }

        private void btnReporting_Click(object sender, RoutedEventArgs e)
        {
            ReportingHome reporting = new ReportingHome();
            reporting.Show();
            this.Hide();
        }

        private void btnAppointments_Click(object sender, RoutedEventArgs e)
        {
            AppointmentHome appointment = new AppointmentHome();
            appointment.Show();
            this.Hide();
        }

        private void btnMedAdvice_Click(object sender, RoutedEventArgs e)
        {
            MedAdviceHome medAdvice = new MedAdviceHome();
            medAdvice.Show();
            this.Hide();
        }
    }
}
