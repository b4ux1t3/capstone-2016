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
        Window SourceWindow;
        public DBReport(Window sourceWindow)
        {
            InitializeComponent();

            this.SourceWindow = sourceWindow;
        }

        private void btnOkay_Click(object sender, RoutedEventArgs e)
        {
            SourceWindow.Show();
            this.Close();
        }
    }
}
