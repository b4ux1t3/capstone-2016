﻿using System;
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
    /// Interaction logic for ReportingHome.xaml
    /// </summary>
    public partial class ReportingHome : Window
    {
        internal Window HomeWindow;

        public ReportingHome(Window sourceWindow)
        {
            InitializeComponent();
            this.HomeWindow = sourceWindow;
        }
    }
}
