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
    /// Interaction logic for Testing.xaml
    /// </summary>
    public partial class Testing : Window
    {
        public Testing()
        {
            InitializeComponent();
        }
        DBConnector connector = new DBConnector();
        private void btnInsertPatient_Click(object sender, RoutedEventArgs e)
        {
            DBConnector.Patient pat = new DBConnector.Patient("F", "Testia", "McTesterson", "(555) 555-5555");
            if (connector.Insert(pat))
            {
                labInsertTest.Content = "Patient Insertion Test Successful! :)";
            }
            else
            {
                labInsertTest.Content = "Patient Insertion Test Unsuccessful! :(";
            }
        }

        private void btnInsertStaff_Click(object sender, RoutedEventArgs e)
        {
            DBConnector.Staff staff = new DBConnector.Staff("0", "Testy", "Testosterone", "5555555557");
            if (connector.Insert(staff))
            {
                labInsertTest.Content = "Staff Insertion Test Successful! :)";
            }
            else
            {
                labInsertTest.Content = "Staff  Insertion Test Unsuccessful! :(";
            }
        }

        private void btnInsertTreatment_Click(object sender, RoutedEventArgs e)
        {
            DBConnector.Treatment treat = new DBConnector.Treatment("Test", "Developer testing. If this shows up in production, the patient is screwed");
            if (connector.Insert(treat))
            {
                labInsertTest.Content = "Treatment Insertion Test Successful! :)";
            }
            else
            {
                labInsertTest.Content = "Treatment Insertion Test Unsuccessful! :(";
            }
        }

        private void btnInsertAppointment_Click(object sender, RoutedEventArgs e)
        {
            labInsertTest.Content = "I haven't figured out how I want to work with appoinments yet. Deal with it.";
        }

        private void btnDeletePatient_Click(object sender, RoutedEventArgs e)
        {
            if(connector.Delete(1, "patients", "patient_ID"))
            {
                labInsertTest.Content = "Patient Deletion Test Successful! :)";
            }
            else
            {
                labInsertTest.Content = "Patient Deletion Test Unsuccessful! :(";
            }
        }

        private void btnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            if (connector.Delete(1, "staff", "staff_ID"))
            {
                labInsertTest.Content = "Staff Deletion Test Successful! :)";
            }
            else
            {
                labInsertTest.Content = "Staff Deletion Test Unsuccessful! :(";
            }
        }

        private void btnDeleteAppointment_Click(object sender, RoutedEventArgs e)
        {
            //if (connector.Delete(1, "appointments", "appointment_ID"))
            //{
            //    labInsertTest.Content = "Appointment Deletion Test Successful! :)";
            //}
            //else
            //{
            //    labInsertTest.Content = "Appointment Deletion Test Unsuccessful! :(";
            //}
        }

        private void btnDeleteTreatment_Click(object sender, RoutedEventArgs e)
        {
            if (connector.Delete(1, "treatments", "treatment_ID"))
            {
                labInsertTest.Content = "Treatment Deletion Test Successful! :)";
            }
            else
            {
                labInsertTest.Content = "Treatment Deletion Test Unsuccessful! :(";
            }
        }
    }
}
