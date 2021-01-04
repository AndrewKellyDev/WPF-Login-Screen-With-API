﻿using Login.Functions;
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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_ButtonClick(object sender, RoutedEventArgs e)
        {
            string response = LoginAPIRequest.Login(EmailInputBox.Text , PasswordInputBox.Password.ToString());
            ErrorMessage.Text = response;
        }

        private void RegisterAccount_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
