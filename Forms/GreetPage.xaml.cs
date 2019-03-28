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
            Slider_Temperature.Value = 0.5;
        }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    DisplayAlert("title", "message", "cancel");
        //}

        //void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    Label_SliderValue.Text = e.NewValue.ToString();
        //    Label_SliderValue.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}
