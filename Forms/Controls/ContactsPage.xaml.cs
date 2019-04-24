using Forms.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public ContactsPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>
            {
                new Contact{id=1, FirstName="William",LastName="Wen",Email="william.wen@g", Phone="111"},
                new Contact{id=2, FirstName="Henry", LastName="Wen",Email="henry.wen@g",Phone="222"},
            };
            ListView_Contacts.ItemsSource = _contacts;
        }

        private void ToolbarItem_Add_Clicked(object sender, EventArgs e)
        {

        }

        private async void MenuItem_Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            if (await DisplayAlert("Warning", $"Are you sure want to delete {contact.FullName}", "Yes", "No"))
                _contacts.Remove(contact);
        }

        private async void ListView_Contacts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ContactDetailPage());
        }
    }
}