using System;

using Xamarin.Forms;

namespace Forms
{
    public class GridPage : ContentPage
    {
        public GridPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

