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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task10.ViewModel;

namespace Task10
{
    public partial class MainWindow : Window
    {
        private ViewModelContext Context
        {
            get
            {
                return this.DataContext as ViewModelContext;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Context.ClickExpCollapseButton(button.DataContext as ViewNode); 
        }

        private void HeaderClickAllocated(object sender, RoutedEventArgs e)
        {

        }

        private void HeaderClickSubFolders(object sender, RoutedEventArgs e)
        {

        }

        private void HeaderClickSubFiles(object sender, RoutedEventArgs e)
        {

        }

        private void HeaderClickPercentParent(object sender, RoutedEventArgs e)
        {

        }
    }
}
