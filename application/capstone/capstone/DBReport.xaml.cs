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
    /// Interaction logic for DBReport.xaml
    /// </summary>
    public partial class DBReport : Window
    {
        Main HomeWindow;
        Window Source;
        public DBReport(Main main, Window source)
        {
            InitializeComponent();
            this.HomeWindow = main;
            this.Source = source;
        }

        private void btnOkay_Click(object sender, RoutedEventArgs e)
        {
            Source.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
