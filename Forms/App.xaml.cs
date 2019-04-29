using System;
using System.IO;
using Forms.Controls;
using Forms.Data;
using Forms.DataAccess;
using Forms.Images;
using Forms.Lists;
using Forms.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms
{
    public partial class App : Application
    {
        private const string DescriptionKey = "Description";
        private const string NotificationKey = "NotificationKey";

        private static TodoItemDatabase _database;

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
            //MainPage = new ImagePage1();

            // 05. Lists
            //MainPage = new Forms.Lists.BasicListPage();
            //MainPage = new AirbnbPage();

            // 06. Navigation
            //MainPage = new NavigationPage(new WelcomePage()) {
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White,
            //};
            //MainPage =new NavigationPage( new ContactsPage());
            //MainPage = new ContactsPage();
            //MainPage = new TabbedNaviPage();
            //MainPage = new NavigationPage(new ToolbarPage()); // new ToolbarPage();
            //MainPage = new InstagramPage();
            //MainPage = new TableViewPage();
            //MainPage = new NavigationPage(new TableViewPage());
            //MainPage = new NavigationPage(new Controls.ContactsPage());

            // 08. Data Access
            //MainPage = new ApplicationPropertiesPage();
            //MainPage = new FileSystemPage();
            //MainPage = new NavigationPage(new TodoItemsPage());
            MainPage = new RESTfulPage();
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

        public string Description
        {
            get
            {
                if (Properties.ContainsKey(DescriptionKey))
                    return Properties[DescriptionKey].ToString();
                return "";
            }
            set
            {
                Properties[DescriptionKey] = value;
            }
        }

        public bool Notification
        {
            get
            {
                if (Properties.ContainsKey(NotificationKey))
                    return (bool)Properties[NotificationKey];
                return false;
            }
            set
            {
                Properties[NotificationKey] = value;
            }
        }
        public static TodoItemDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new TodoItemDatabase(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "TodoItemSQLite.db3"));
                }
                return _database;
            }
        }
    }
}
