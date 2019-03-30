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
            var label = new Label { };
        }
    }
}
