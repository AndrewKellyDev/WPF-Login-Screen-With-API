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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_ButtonClick(object sender, RoutedEventArgs e)
        {
            string response = LoginAPIRequest.Register(NameInputBox.Text ,EmailInputBox.Text, PasswordInputBox.Password.ToString());
            ErrorMessage.Text = response;
        }
    }
}
