using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms
{
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();
            Content = layout;
            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(
                aquaBox, 
                new Rectangle(0, 0, 1, 1),
                AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0.5, 0.5, 100, 100));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.PositionProportional);
        }
    }
}
