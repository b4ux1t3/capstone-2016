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
    /// Interaction logic for TestLogIn.xaml
    /// </summary>
    public partial class TestLogIn : Window
    {
        public TestLogIn()
        {
            InitializeComponent();
        }

        private void btnNonAdmin_Click(object sender, RoutedEventArgs e)
        {
            Main home = new Main(false, 123, new DBConnector("192.168.1.9","capstone","application","java see sharp myess queue ell"));
            home.Show();
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            Main home = new Main(true, 123, new DBConnector("192.168.1.9", "capstone", "application", "java see sharp myess queue ell"));
            home.Show();
        }
    }
}
