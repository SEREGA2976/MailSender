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

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow() => InitializeComponent();
        

        private void OnExitClick(object sender, RoutedEventArgs E) => Close();

        private void TabController_OnLeftButtonClick(object Sender, EventArgs e)
        {

            MainTabControl.SelectedIndex--;

        }
        private void TabController_OnRightButtonClick(object Sender, EventArgs e)
        {

            MainTabControl.SelectedIndex++;

        }

    }
}
