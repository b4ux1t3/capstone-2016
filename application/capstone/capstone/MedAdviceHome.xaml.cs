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
    /// Interaction logic for MedAdviceHome.xaml
    /// </summary>
    public partial class MedAdviceHome : Window
    {
        internal Main HomeWindow;
        public MedAdviceHome(Main sourceWindow)
        {
            InitializeComponent();
            this.HomeWindow = sourceWindow;
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            PatientLookup lookup = new PatientLookup(this, HomeWindow);
            lookup.Show();
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }

        private void buttsub_Click(object sender, RoutedEventArgs e)
        {
            MedReport report = new MedReport(HomeWindow);
            report.Show();
            this.Close();
            HomeWindow.Hide();
        }
    }
}
