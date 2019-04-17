using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Navigation
{
    //public partial class ContactsPage : ContentPage
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : MasterDetailPage
    {
        private List<Contact> contacts;

        public ContactsPage()
        {
            InitializeComponent();

            contacts = new List<Contact>
            {
                new Contact{Name="William", Status="Let's talk about Xamarin", ImageUrl="http://lorempixel.com/100/100/people/3",}
                ,
                new Contact{Name="Henry", Status="Let's talk about Minecraft", ImageUrl="http://lorempixel.com/100/100/people/4",}
                ,
            };

            ListView_Contracts.ItemsSource = contacts;
        }

        private void ListView_Contracts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null)
            //    return;
            var contact = e.SelectedItem as Contact;
            //await Navigation.PushAsync(new ContactDetailPage(contact));
            Detail = new NavigationPage(new ContactDetailPage(contact));
            //ListView_Contracts.SelectedItem = null;
            IsPresented = false; // IsMasterPresented.
        }
    }
}