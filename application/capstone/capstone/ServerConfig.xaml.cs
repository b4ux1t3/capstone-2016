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
using MySql.Data.MySqlClient;

namespace capstone
{
    /// <summary>
    /// Interaction logic for ServerConfig.xaml
    /// </summary>
    public partial class ServerConfig : Window
    {
        internal DBConnector Connector;
        public ServerConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtServer.Text != String.Empty && txtUserName.Text != String.Empty && txtUserName.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                try
                {
                    Connector = new DBConnector(txtServer.Text, txtDatabase.Text, txtUserName.Text, txtPassword.Text);
                    Main MainWindow = new Main(Connector, this);
                    MainWindow.Show();
                    this.Close();
                } catch(MySqlException ex)
                {
                    MessageBox.Show("Error connecting to server.");
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
