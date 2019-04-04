using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new StackPage();
            //MainPage = new GridPage();
            //MainPage = new GridPage1();
            //MainPage = new GridPage2();
            //MainPage = new AbsolutePage();
            //MainPage = new AbsolutePage1();
            //MainPage = new AbsolutePage2();
            MainPage = new RelativePage();
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
