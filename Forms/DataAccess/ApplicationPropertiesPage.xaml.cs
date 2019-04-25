using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationPropertiesPage : ContentPage
    {
        //private const string DescriptionKey = "Description";
        //private const string NotificationKey = "NotificationKey";

        public ApplicationPropertiesPage()
        {
            var app = Application.Current as App;
            InitializeComponent();
            BindingContext = app;
            //EntryCell_Description.Text = app.Description;

            //SwitchCell_Notification.On = app.Notification;
        }

        //protected async override void OnDisappearing()
        //{
            //await Application.Current.SavePropertiesAsync();
        //    base.OnDisappearing();
        //}

        //private void InputOnChanged(object sender, EventArgs e)
        //{
            //var app = Application.Current as App;
            //app.Description = EntryCell_Description.Text;
            //app.Notification = SwitchCell_Notification.On;

            //Application.Current.SavePropertiesAsync();
        //}

    }
}