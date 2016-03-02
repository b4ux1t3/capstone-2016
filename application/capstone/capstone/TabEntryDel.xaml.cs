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
    /// Interaction logic for TabEntryDel.xaml
    /// </summary>
    public partial class TabEntryDel : Window
    {
        internal Main MainWindow;

        private string idField;
        private string id;
        private string table;

        internal TabEntryDel(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
            tableSelect.Items.Add("Staff");
            tableSelect.Items.Add("Patient");
            tableSelect.Items.Add("Treatment");
            tableSelect.Items.Add("Appointment");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(idField != null && txtID.ToString() != String.Empty)
            {
                id = txtID.Text;
                try
                {
                    if (MainWindow.Connector.Delete(id, table, idField))
                    {
                        MainWindow.Show();
                        this.Close();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("There was an error. Here it is. Exiting to Home Window\n" + ex.Message);
                    MainWindow.Show();
                    this.Close();
                }
                
                
            }
            else
            {
                MessageBox.Show("Please make sure you have a table selected and an ID entered");
            }
            
        }

        private void tableSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tableSelect.SelectedItem.ToString() == "Staff")
            {
                idField = "staff_ID";
                table = "staff";
            }
            else if (tableSelect.SelectedIndex.ToString() == "Patient")
            {
                idField = "patient_ID";
                table = "patients";
            }
            else if (tableSelect.SelectedIndex.ToString() == "Treatment")
            {
                idField = "treatment_ID";
                table = "treatments";
            }
            else if (tableSelect.SelectedIndex.ToString() == "Appointment")
            {
                idField = "appointment_ID";
                table = "appointments";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Show();
        }        
    }
}