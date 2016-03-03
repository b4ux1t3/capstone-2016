using System;
using System.Collections.Generic;
using System.Data;
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
            string query = "SELECT * FROM patients WHERE ";
            bool andFlag = false;
            // Fill out the query
            if(txtAddress.Text != String.Empty)
            {
                query = String.Format(query + "address = '{0}' ", txtAddress.Text);
                andFlag = true;
            }
            if(txtPhone.Text != String.Empty)
            {
                if (andFlag)
                {
                    query = String.Format(query + "AND phone = '{0}' ", txtPhone.Text);
                }
                else
                {
                    query = String.Format(query + "phone = '{0}' ", txtPhone.Text);
                }
                andFlag = true;
                
            }
            if(txtFirstName.Text != String.Empty)
            {
                if (andFlag)
                {
                    query = String.Format(query + "AND first_name = '{0}' ", txtFirstName.Text);
                }
                else
                {
                    query = String.Format(query + "first_name = '{0}' ", txtFirstName.Text);
                }
                andFlag = true;
            }
            if(txtLastName.Text != String.Empty)
            {
                if (andFlag)
                {
                    query = String.Format(query + "AND last_name = '{0}' ", txtLastName.Text);
                }
                else
                {
                    query = String.Format(query + "last_name = '{0}' ", txtLastName.Text);
                }
                andFlag = true;
            }
            if(txtBDayDay.Text != String.Empty && txtBDayMonth.Text != String.Empty && txtBDayYear.Text != String.Empty)
            {
                string birthday = txtBDayMonth.Text + "/" + txtBDayDay.Text + "/" + txtBDayYear.Text;

                if (andFlag)
                {
                    query = String.Format(query + "AND first_name = '{0}' ", birthday);
                }
                else
                {
                    query = String.Format(query + "firstName = '{0}' ", birthday);
                }
                andFlag = true;
            }
            // End the query with a semicolon
            query += ";";

            DataTable data = HomeWindow.Connector.SendQuery(query);
            DBReport report = new DBReport(HomeWindow, Source, data);
            report.Show();
            this.Close();
            HomeWindow.Hide();
        }

        private void winPatient_Lookup_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
