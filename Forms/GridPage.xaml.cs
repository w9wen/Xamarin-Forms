using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            var gird = new Grid 
            {
                RowSpacing = 20,
                ColumnSpacing = 40, 
            };
            var label = new Label {Text="Label 1" };
            gird.Children.Add(label, 0, 0);
            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);

            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);

            gird.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });

            gird.RowDefinitions.Add(new RowDefinition 
            {
                Height = new GridLength(2, GridUnitType.Star) 
            });
            gird.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Auto)
            });
        }
    }
}
