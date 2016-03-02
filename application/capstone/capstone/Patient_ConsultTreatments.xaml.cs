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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class WinPatientTreatment : Window
    {
        Main MainWindow;
        public WinPatientTreatment(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Show();
        }
    }
}
