using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms
{
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();

            // Not suggested in code.
            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 50, 0, 0),
                Orientation = StackOrientation.Horizontal,
            };
            layout.Children.Add(new Label { Text = "Label 1" });
            Content = layout;
        }
    }
}
