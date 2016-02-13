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
    /// Interaction logic for WinHomeAdmin.xaml
    /// </summary>
    public partial class WinHomeAdmin : Window
    {
        public WinHomeAdmin()
        {
            InitializeComponent();
        }
        private void btnPatients_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("It worked!");
        }

        private void btnReporting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAppointments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMedAdvice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDBM_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
