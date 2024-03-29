﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            HotReloader.Current.Run(this);

            var vm = new ViewModels.MainVm();

            MainPage = new NavigationPage(vm.View);
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
