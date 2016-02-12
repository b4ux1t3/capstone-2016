using System.Windows;
using System.Windows.Controls;

namespace capstone
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class WinLogIn : Window
    {
        
        public WinLogIn()
        {
            InitializeComponent();
        }
        DBConnector connector = new DBConnector();
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtStaffID.Text != string.Empty && connector.CheckLogIn(txtStaffID.Text) != 0)
            {
                Testing test = new Testing();
                test.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID!");
            }
        }
    }
}
