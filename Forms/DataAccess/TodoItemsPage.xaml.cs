using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemsPage : ContentPage
    {
        public TodoItemsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListView_TodoItems.ItemsSource =
                await App.Database.GetItemsAsync();
        }
        private async void ToolbarItem_Insert_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage { BindingContext = new TodoItem() });
        }

        private async void ListView_TodoItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
            }
        }

        private async void ListView_MenuItem_Delete_Clicked(object sender, EventArgs e)
        {
            var todoItem = (sender as MenuItem).CommandParameter as TodoItem;
            await App.Database.DeleteItem(todoItem);
            //await DisplayAlert("TodoItem", todoItem.Name, "OK");
        }
    }
}