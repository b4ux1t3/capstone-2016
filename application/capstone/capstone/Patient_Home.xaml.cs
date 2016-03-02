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
    /// Interaction logic for Patient_Home.xaml
    /// </summary>
    public partial class PatientHome : Window
    {
       internal  Main HomeWindow;

        public PatientHome(Main sourceWindow)
        {
            InitializeComponent();
            this.HomeWindow = sourceWindow;
        }

        private void btnConsultation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPatientLookup_Click(object sender, RoutedEventArgs e)
        {
            PatientLookup lookup = new PatientLookup(this);
            lookup.Show();
            this.Hide();
        }

        private void btnNewPatientReg_Click(object sender, RoutedEventArgs e)
        {
            PatientRegistration register = new PatientRegistration(this.HomeWindow); 
            register.Show();
            this.Close();
        }

        private void winPatient_Home_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
