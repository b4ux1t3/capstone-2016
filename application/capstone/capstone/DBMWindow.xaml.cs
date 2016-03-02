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
    /// Interaction logic for DBMWindow.xaml
    /// </summary>
    public partial class WinDBM : Window
    {
        internal Main HomeWindow;

        /// <summary>
        /// Constructor for the Database Management Window
        /// </summary>
        /// <param name="sourceWindow">The window from which this window was accessed</param>
        public WinDBM(Main sourceWindow)
        {
            InitializeComponent();
            this.HomeWindow = sourceWindow;
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            TabEntryDel delete = new TabEntryDel(this.HomeWindow);
            delete.Show();
            this.Close();
            HomeWindow.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
