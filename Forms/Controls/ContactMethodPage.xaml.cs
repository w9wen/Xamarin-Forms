using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMethodPage : ContentPage
    {
        public ContactMethodPage()
        {
            InitializeComponent();
            ListView_ContactMethod.ItemsSource = new List<string>
            {
                "None",
                "SMS",
                "Email",
            };
        }

        public ListView ContactMethods { get { return ListView_ContactMethod; } }

    }
}