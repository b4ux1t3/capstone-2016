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
    /// Interaction logic for InsertHome.xaml
    /// </summary>
    public partial class InsertHome : Window
    {
        Main MainWindow;
        public InsertHome(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            NewStaff staff = new NewStaff(MainWindow);
            staff.Show();
            this.Close();
            MainWindow.Hide();
        }

        private void btnTreatment_Click(object sender, RoutedEventArgs e)
        {
            insertTreatment treat = new insertTreatment(MainWindow);
            treat.Show();
            this.Close();
            MainWindow.Hide();
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            NewSchedule schedule = new NewSchedule(MainWindow);
            schedule.Show();
            this.Close();
            MainWindow.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Show();
        }
    }
}
