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
        public ApplicationPropertiesPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Description"))
                EntryCell_Description.Text = Application.Current.Properties["Description"].ToString();

            if (Application.Current.Properties.ContainsKey("Notification"))
                SwitchCell_Notification.On = (bool)Application.Current.Properties["Notification"];
        }

        protected async override void OnDisappearing()
        {
            await Application.Current.SavePropertiesAsync();
            base.OnDisappearing();
        }

        private void InputOnChanged(object sender, EventArgs e)
        {
            Application.Current.Properties["Description"] = EntryCell_Description.Text;
            Application.Current.Properties["Notification"] = SwitchCell_Notification.On;

            //Application.Current.SavePropertiesAsync();
        }

    }
}