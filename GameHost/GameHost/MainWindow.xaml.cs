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
using WcfServiceGame;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace GameHost
{
    /// <summary>
    /// Game Host
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ServiceHost host = null;

        private void Window_Initialized(object sender, EventArgs e)
        {
            try
            {
                host = new ServiceHost(typeof(GameService));
                host.Description.Behaviors.Add(
                    new ServiceMetadataBehavior { HttpGetEnabled = true });
                host.Open();
                lb.Content = "Connected...";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (host != null)
            {
                host.Close();
            }
        }
    }
}
