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
    /// Interaction logic for insertTreatment.xaml
    /// </summary>
    /// Implemented by Erica Blinder
    public partial class insertTreatment : Window
    {
        internal Main MainWindow;
        internal insertTreatment(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
        }

        private void txtTreatmentTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTreatmentDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if ((txtTreatmentTitle.Text != String.Empty &&
               txtTreatmentDescription.Text != String.Empty))
            {

                string treatment = txtTreatmentTitle.Text;
                string description = txtTreatmentDescription.Text;

                DBConnector.Treatment newTreatment = new DBConnector.Treatment(treatment, description);
                MainWindow.Connector.Insert(newTreatment);
            }

            else

            {
                MessageBox.Show("Please make sure all of the information is filled out. Stop trying to break things. Thank you.");
            }
        }

        private void winNewTreatment_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Show();
        }
    }
}
