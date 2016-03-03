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
    /// Interaction logic for NewSchedule.xaml
    /// </summary>
    public partial class NewSchedule : Window
    {
        Main MainWindow;
        public NewSchedule(Main main)
        {
            InitializeComponent();
            this.MainWindow = main;
        }

        private void moff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(m110.IsChecked))
            {
                m110.IsChecked = false;
            }
            if (Convert.ToBoolean(m1523.IsChecked))
            {
                m1523.IsChecked = false;
            }
            if (Convert.ToBoolean(m916.IsChecked))
            {
                m916.IsChecked = false;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.Show();
        }

        private void toff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(t110.IsChecked))
            {
                t110.IsChecked = false;
            }
            if (Convert.ToBoolean(t1523.IsChecked))
            {
                t1523.IsChecked = false;
            }
            if (Convert.ToBoolean(t916.IsChecked))
            {
                t916.IsChecked = false;
            }
        }

        private void woff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(w110.IsChecked))
            {
                w110.IsChecked = false;
            }
            if (Convert.ToBoolean(w1523.IsChecked))
            {
                w1523.IsChecked = false;
            }
            if (Convert.ToBoolean(w916.IsChecked))
            {
                w916.IsChecked = false;
            }
        }

        private void thoff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(th110.IsChecked))
            {
                th110.IsChecked = false;
            }
            if (Convert.ToBoolean(th1523.IsChecked))
            {
                th1523.IsChecked = false;
            }
            if (Convert.ToBoolean(th916.IsChecked))
            {
                th916.IsChecked = false;
            }
        }

        private void foff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(f110.IsChecked))
            {
                f110.IsChecked = false;
            }
            if (Convert.ToBoolean(f1523.IsChecked))
            {
                f1523.IsChecked = false;
            }
            if (Convert.ToBoolean(f916.IsChecked))
            {
                f916.IsChecked = false;
            }
        }

        private void saoff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(sa110.IsChecked))
            {
                sa110.IsChecked = false;
            }
            if (Convert.ToBoolean(sa1523.IsChecked))
            {
                sa1523.IsChecked = false;
            }
            if (Convert.ToBoolean(sa916.IsChecked))
            {
                sa916.IsChecked = false;
            }
        }

        private void suoff_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(su110.IsChecked))
            {
                su110.IsChecked = false;
            }
            if (Convert.ToBoolean(su1523.IsChecked))
            {
                su1523.IsChecked = false;
            }
            if (Convert.ToBoolean(su916.IsChecked))
            {
                su916.IsChecked = false;
            }
        }

        private void m110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(moff.IsChecked)){
                moff.IsChecked = false;
            }
        }

        private void m916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(moff.IsChecked))
            {
                moff.IsChecked = false;
            }
        }

        private void m1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(moff.IsChecked))
            {
                moff.IsChecked = false;
            }
        }

        private void t110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(toff.IsChecked))
            {
                toff.IsChecked = false;
            }
        }

        private void t916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(toff.IsChecked))
            {
                toff.IsChecked = false;
            }
        }

        private void t1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(toff.IsChecked))
            {
                toff.IsChecked = false;
            }
        }

        private void w110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(woff.IsChecked))
            {
                woff.IsChecked = false;
            }
        }

        private void w916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(woff.IsChecked))
            {
                woff.IsChecked = false;
            }
        }

        private void w1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(woff.IsChecked))
            {
                woff.IsChecked = false;
            }
        }

        private void th110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(thoff.IsChecked))
            {
                thoff.IsChecked = false;
            }
        }

        private void th916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(thoff.IsChecked))
            {
                thoff.IsChecked = false;
            }
        }

        private void th1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(thoff.IsChecked))
            {
                thoff.IsChecked = false;
            }
        }

        private void f110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(foff.IsChecked))
            {
                foff.IsChecked = false;
            }
        }

        private void f916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(foff.IsChecked))
            {
                foff.IsChecked = false;
            }
        }

        private void f1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(foff.IsChecked))
            {
                foff.IsChecked = false;
            }
        }

        private void sa110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(saoff.IsChecked))
            {
                saoff.IsChecked = false;
            }
        }

        private void sa916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(saoff.IsChecked))
            {
                saoff.IsChecked = false;
            }
        }

        private void sa1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(saoff.IsChecked))
            {
                saoff.IsChecked = false;
            }
        }

        private void su110_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(suoff.IsChecked))
            {
                suoff.IsChecked = false;
            }
        }

        private void su916_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(suoff.IsChecked))
            {
                suoff.IsChecked = false;
            }
        }

        private void su1523_Checked(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(suoff.IsChecked))
            {
                suoff.IsChecked = false;
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
