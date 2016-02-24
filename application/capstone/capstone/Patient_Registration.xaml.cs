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
    /// Interaction logic for Patient_Registration.xaml
    /// </summary>
    public partial class PatientRegistration : Window
    {
        internal Main MainWindow;
        internal PatientRegistration(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            DBConnector.Patient newPatient = new DBConnector.Patient("F", "Test", "test", "1800test000");
            MainWindow.Connector.Insert(newPatient);
        }
    }
}
