using System;
using System.Collections.Generic;
using Forms.Models;
using Xamarin.Forms;

namespace Forms.Lists
{
    public partial class BasicListPage : ContentPage
    {
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
            ListView_Name.ItemsSource = new List<Contact>
            {
                new Contact{Name="William",ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Henry",ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hello, Let's talk"},
            };
        }
    }
}
