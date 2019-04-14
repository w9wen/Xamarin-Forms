using System;
using Forms.Images;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new GreetPage();
            //MainPage = new StackPage();
            //MainPage = new GridPage();
            //MainPage = new GridPage1();
            //MainPage = new GridPage2();
            //MainPage = new AbsolutePage();
            //MainPage = new AbsolutePage1();
            //MainPage = new AbsolutePage2();
            //MainPage = new RelativePage();
            //MainPage = new RelativePage1();

            // 04. Images
            //MainPage = new ImagePage();
            MainPage = new ImagePage1();
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
