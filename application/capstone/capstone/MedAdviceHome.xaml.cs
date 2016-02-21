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
    /// Interaction logic for MedAdviceHome.xaml
    /// </summary>
    public partial class MedAdviceHome : Window
    {
        internal Window HomeWindow;
        public MedAdviceHome(Window sourceWindow)
        {
            InitializeComponent();
            this.HomeWindow = sourceWindow;
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            PatientLookup lookup = new PatientLookup(this);
            lookup.Show();
            this.Hide();
        }
    }
}
