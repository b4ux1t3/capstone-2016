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
        internal Window HomeWindow;

        /// <summary>
        /// Constructor for the Database Management Window
        /// </summary>
        /// <param name="sourceWindow">The window from which this window was accessed</param>
        public WinDBM(Window sourceWindow)
        {
            InitializeComponent();
            this.HomeWindow = sourceWindow;
        }
    }
}
