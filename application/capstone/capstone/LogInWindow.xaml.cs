using System.Windows;
using System.Windows.Controls;

namespace capstone
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class WinLogIn : Window
    {
        DBConnector connector = new DBConnector();

        public WinLogIn()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Todo: Make this wire up to the home page, and change DBConnector.CheckLogIn so that it also returns whether or not the user is an admin.
            if (txtStaffID.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid Staff ID!");
            }
            else if (connector.CheckLogIn(txtStaffID.Text) >= 0)
            {
                if (connector.CheckAdminStatus(txtStaffID.Text))
                {
                    WinHomeAdmin adminWindow = new WinHomeAdmin();
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    WinHome homeWindow = new WinHome();
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
