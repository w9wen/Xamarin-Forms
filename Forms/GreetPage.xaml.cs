using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("title", "message", "cancel");
        }
    }
}
