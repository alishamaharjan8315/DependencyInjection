﻿using PeopleViewer.Presentation;
using PersonDataReader.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObjects();
            Current.MainWindow.Title = "With Dependency Injection";
            Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            var reader = new ServiceReader();
            var viewModel = new PeopleViewModel(reader);
            Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
