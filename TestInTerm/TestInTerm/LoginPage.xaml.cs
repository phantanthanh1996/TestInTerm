﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestInTerm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Move_ForgotPass(object sender, EventArgs e)
        {

        }

        private void Move_SignUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }
    }
}