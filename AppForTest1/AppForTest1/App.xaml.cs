﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppForTest1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var np = new NavigationPage(new NavPage1());
            var tp = new TabbedPage();
            tp.Children.Add(new TabbedPage1());
            tp.Children.Add(new TabbedPage2());
            tp.Children.Add(new TabbedPage3());

            var cp = new CarouselPage();
            cp.Children.Add(new TabbedPage1());
            cp.Children.Add(new TabbedPage2());
            cp.Children.Add(new TabbedPage3());

            var mp = new MasterDetailPage();
            mp.Master = new MenuPage();
            mp.Detail = new NavigationPage(new MainPage());

            MainPage = mp;
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
