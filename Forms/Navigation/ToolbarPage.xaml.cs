using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarPage : ContentPage
    {
        public ToolbarPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var toolbarItem = sender as ToolbarItem;
            DisplayAlert("Title", toolbarItem.Text, "OK");
        }
    }
}