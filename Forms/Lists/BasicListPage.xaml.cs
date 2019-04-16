using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Forms.Models;
using Xamarin.Forms;

namespace Forms.Lists
{
    public partial class BasicListPage : ContentPage
    {
        //private List<ContactGroup> _contacts;
        //private List<Contact> _contacts;
        private ObservableCollection<Contact> _contacts;

        public BasicListPage()
        {
            InitializeComponent();
            //var names = new List<String>
            //{
            //    "William",
            //    "May",
            //    "Henry",
            //    "Jack",
            //};
            //ListView_Name.ItemsSource = names;
            //ListView_Name.ItemsSource = new List<Contact>
            //{
            //    new Contact{Name="William",ImageUrl="http://lorempixel.com/100/100/people/1"},
            //    new Contact{Name="Henry",ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hello, Let's talk"},
            //};

            //_contacts = new List<ContactGroup>
            //{
            //    new ContactGroup("W", "W"){
            //        new Contact{Name="William", Status="Let's talk about Xamarin", ImageUrl="http://lorempixel.com/100/100/people/2",}
            //    },
            //    new ContactGroup("H", "H"){
            //        new Contact{Name="Henry", Status="Let's talk about Minecraft", ImageUrl="http://lorempixel.com/100/100/people/4",}
            //    },
            //};

            //_contacts = new ObservableCollection<Contact>
            //{
            //    new Contact{Name="William", ImageUrl="http://lorempixel.com/100/100/people/5", Status="Code Master"},
            //    new Contact{Name="Henry", ImageUrl="http://lorempixel.com/100/100/people/6", Status="Code Player"},
            //};

            ListView_Name.ItemsSource = GetContacts();
        }

        private ObservableCollection<Contact> GetContacts()
        {
            _contacts = new ObservableCollection<Contact>
            {
                new Contact{Name="William", ImageUrl="http://lorempixel.com/100/100/people/5", Status="Code Master"},
                new Contact{Name="Henry", ImageUrl="http://lorempixel.com/100/100/people/6", Status="Code Player"},
            };
            return _contacts;
        }

        void ListView_Name_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = (Contact)e.SelectedItem;
            DisplayAlert("Selected", contact.Name, "OK");
        }

        void ListView_Name_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = (Contact)e.Item;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void MenuItem_Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void MenuItem_Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
            DisplayAlert("Delete", contact.Name, "OK");
        }

        private void ListView_Name_Refreshing(object sender, EventArgs e)
        {
            ListView_Name.ItemsSource = GetContacts();
            ListView_Name.EndRefresh();
        }
    }
}
