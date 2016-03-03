using System;
using System.Collections.Generic;
using System.Data;
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
        DataTable Data;
        public DBReport(Main main, Window source, DataTable data)
        {
            InitializeComponent();
            this.HomeWindow = main;
            this.Source = source;
            this.Data = data;
        }

        private void btnOkay_Click(object sender, RoutedEventArgs e)
        {
            Source.Show();
            this.Close();
            HomeWindow.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
