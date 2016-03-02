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
            if ((txtAddress.Text != String.Empty &&
                txtArea.Text != String.Empty && 
                txtBDayDay.Text != String.Empty && 
                txtBDayMonth.Text != String.Empty && 
                txtBDayYear.Text != String.Empty && 
                txtFirstName.Text != String.Empty && 
                txtLine.Text != String.Empty && 
                txtSwitch.Text != String.Empty && 
                txtLastName.Text != String.Empty && 
                txtInsurance.Text != String.Empty) 
                && 
                (Convert.ToBoolean(radbtnFemale.IsChecked) || Convert.ToBoolean(radbtnMale.IsChecked)))
            {
                string gender;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phone = txtArea.Text + txtSwitch.Text + txtLine.Text;
                string insurance = txtInsurance.Text;
                string birthday = txtBDayMonth.Text + "/" + txtBDayDay.Text + "/" + txtBDayYear.Text;
                string address = txtAddress.Text;

                if (Convert.ToBoolean(radbtnFemale.IsChecked))
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                DBConnector.Patient newPatient = new DBConnector.Patient(gender, firstName, lastName, phone, insurance, birthday, address);
                MainWindow.Connector.Insert(newPatient);
            }
            else
            {
                MessageBox.Show("Please make sure all of teh information is filled out. Stop trying to break things.");
            }
            
        }

        private void winPatient_Reg_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Show();
        }
    }
}
