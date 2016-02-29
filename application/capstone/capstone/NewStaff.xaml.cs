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
    /// Interaction logic for NewStaff.xaml
    /// </summary>
    /// JOSE DONE DID DIS ISH RY HEEERE ///
    public partial class NewStaff : Window
    {
        internal Main MainWindow;
        internal NewStaff(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtFirstName.Text != String.Empty && txtLastName.Text != String.Empty && txtPhone.Text != String.Empty)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phone = txtPhone.Text;
                string admin;

                if (Convert.ToBoolean(chkAdmin.IsChecked))
                {
                    admin = "1";
                }
                else
                {
                    admin = "0";
                }

                DBConnector.Staff newStaff = new DBConnector.Staff(admin, firstName, lastName, phone);
                MainWindow.Connector.Insert(newStaff);
            }
            else
            {
                MessageBox.Show("Please make sure all of teh information is filled out. Stop trying to break things.");
            }
        }
    }
}
