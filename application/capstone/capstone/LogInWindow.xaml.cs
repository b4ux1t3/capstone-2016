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
        internal DBConnector Connector;

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
            else if (Connector.CheckLogIn(txtStaffID.Text) >= 0)
            {
                if (Connector.CheckAdminStatus(txtStaffID.Text))
                {
                    Main adminWindow = new Main(true, Convert.ToInt32(txtStaffID.Text), Connector);
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    Main homeWindow = new Main(false, Convert.ToInt32(txtStaffID.Text), Connector);
                    homeWindow.Show();
                    this.Close();
                }
            }
            else if (Connector.CheckLogIn(txtStaffID.Text) <= 0)
            {
                MessageBox.Show("Unable to connect to Database. Contact your administrator.");
            }
            else
            {
                
            }
        }

        private void btnServer_Click(object sender, RoutedEventArgs e)
        {
            ServerConfig serv = new ServerConfig(this);
            serv.Show();
            this.Hide();

        }
    }
}
