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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WinPatientConsult : Window
    {
        Main HomeWindow;
        public WinPatientConsult(Main main)
        {
            InitializeComponent();
            this.HomeWindow = main;
        }

        

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            PatientLookup lookup = new PatientLookup(this);
            lookup.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomeWindow.Show();
        }
    }
}
