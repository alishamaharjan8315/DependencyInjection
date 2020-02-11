﻿using PeopleViewer.Presentation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PeopleViewerWindow : Window
    {
        PeopleViewModel viewModel;
        public PeopleViewerWindow()
        {
            InitializeComponent();
            viewModel = new PeopleViewModel();
            this.DataContext = viewModel;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RefreshPeople();
        }

        private void ClearButton_click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearPeople();
        }
    }
}
