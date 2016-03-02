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
    /// Interaction logic for PatientLookup.xaml
    /// </summary>
    public partial class PatientLookup : Window
    {
        internal Main HomeWindow;
        internal Window Source;
        public PatientLookup(Window sourceWindow, Main main)
        {
            InitializeComponent();
            this.HomeWindow = main;
            this.Source = sourceWindow;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            DBReport report = new DBReport(HomeWindow, Source);
            report.Show();
            this.Close();
        }

        private void winPatient_Lookup_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
