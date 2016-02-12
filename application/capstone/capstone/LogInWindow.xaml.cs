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
            if (txtStaffID.Text != string.Empty && connector.CheckLogIn(txtStaffID.Text) >= 0)
            {
                Testing test = new Testing();
                test.Show();
                this.Close();
            }
            else if (connector.CheckLogIn(txtStaffID.Text) <= 0)
            {
                MessageBox.Show("Unable to connect to Database. Contact your administrator.");
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID!");
            }
        }
    }
}
