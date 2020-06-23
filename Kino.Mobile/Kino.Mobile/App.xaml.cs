﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Kino.Mobile.Services;
using Kino.Mobile.Views;



namespace Kino.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
