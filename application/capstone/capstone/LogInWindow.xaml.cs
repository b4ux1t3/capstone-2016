using System;
using System.Windows;
using System.Windows.Controls;

namespace capstone
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class WinLogIn : Window
    {
        internal DBConnector connector = new DBConnector();

        public WinLogIn()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtStaffID.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid Staff ID!");
            }
            else if (connector.CheckLogIn(txtStaffID.Text) >= 0)
            {
                if (connector.CheckAdminStatus(txtStaffID.Text))
                {
                    Main adminWindow = new Main(true, Convert.ToInt32(txtStaffID.Text), connector);
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    Main homeWindow = new Main(false, Convert.ToInt32(txtStaffID.Text), connector);
                    homeWindow.Show();
                    this.Close();
                }
            }
            else if (connector.CheckLogIn(txtStaffID.Text) <= 0)
            {
                MessageBox.Show("Unable to connect to Database. Contact your administrator.");
            }
            else
            {
                
            }
        }
    }
}
