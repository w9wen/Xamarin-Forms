using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms
{
    public partial class RelativePage : ContentPage
    {
        public RelativePage()
        {
            InitializeComponent();

            var relativeLayout = new RelativeLayout();
            Content = relativeLayout;

            var aquaBox = new BoxView { Color = Color.Aqua };
            relativeLayout.Children.Add(aquaBox,
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));

            var silverBox = new BoxView { Color = Color.Silver };
            relativeLayout.Children.Add(silverBox,
                yConstraint: Constraint.RelativeToView(aquaBox, (RelativeLayout, element)=> element.Height+ 20));
        }
    }
}
