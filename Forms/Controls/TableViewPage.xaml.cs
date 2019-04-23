using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Forms.Controls
{

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public partial class TableViewPage : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        private IList<ContactMethod> GetContactMethod()
        {
            return new List<ContactMethod>
            {
                new ContactMethod{Id=1, Name="SMS"},
                new ContactMethod{Id=2, Name="Email"},
            };
        }

        public TableViewPage()
        {
            InitializeComponent();

            _contactMethods = GetContactMethod();

            foreach (var method in _contactMethods)
            {
                Picker_Selected.Items.Add(method.Name);
            }
        }

        private void EntryCell_Completed(object sender, EventArgs e)
        {

        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            //Label_Switch.IsVisible = e.Value;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Label_SliderValue.Text = e.NewValue.ToString();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label_Entry.Text = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Label_Entry.Text = "Completed";
        }

        private void Picker_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var contact = Picker_Selected.Items[Picker_Selected.SelectedIndex];
            //DisplayAlert("Picker Selected", contact, "OK");
            var name = Picker_Selected.Items[Picker_Selected.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Picker Selected", contactMethod.Name, "OK");
        }
    }
}
