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
            MainWindow.Connector.Delete(id, table, idField);
            MainWindow.Show();
            this.Close();
        }

        private void tableSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tableSelect.SelectedItem.ToString() == "Staff")
            {
                id = "staff_ID";
            }
            else if (tableSelect.SelectedIndex.ToString() == "Patient")
            {
                id = "patient_ID";
            }
            else if (tableSelect.SelectedIndex.ToString() == "Treatment")
            {
                id = "treatment_ID";
            }
            else if (tableSelect.SelectedIndex.ToString() == "Appointment")
            {
                id = "appointment_ID";
            }
        }
    }
}
