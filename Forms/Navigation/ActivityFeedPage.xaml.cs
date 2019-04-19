using Forms.Models;
using Forms.Services;
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
    public partial class ActivityFeedPage : ContentPage
    {
        private ActivityService _activityService = new ActivityService();
        public ActivityFeedPage()
        {
            InitializeComponent();
            ListView_ActivityFeed.ItemsSource = _activityService.GetActivities();
        }

        private void ListView_ActivityFeed_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;
            ListView_ActivityFeed.SelectedItem = null;
        }
    }
}