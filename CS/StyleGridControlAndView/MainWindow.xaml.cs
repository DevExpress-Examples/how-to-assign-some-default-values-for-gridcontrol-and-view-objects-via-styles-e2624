﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;


namespace StyleGridControlAndView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid.DataSource = this.Resources["items"];
            grid1.DataSource = this.Resources["items"];
            grid2.DataSource = this.Resources["items"];
            grid3.DataSource = this.Resources["items"];
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.SetThemeName(this, "Office2007Black");
        }
    }
}
