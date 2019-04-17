using Forms.Models;
using Forms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirbnbPage : ContentPage
    {
        private SearchService searchService;
        private List<SearchGroup> searchGroups;

        public AirbnbPage()
        {
            searchService = new SearchService();
            InitializeComponent();
            PopulateListView(searchService.GetRecentSearches());
        }

        private void PopulateListView(IEnumerable<Search> searches)
        {
            searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };
            ListView_Flights.ItemsSource = searchGroups;
        }

        private void SearchBar_Flights_TextChanged(object sender, TextChangedEventArgs e)
        {
            PopulateListView(searchService.GetRecentSearches(e.NewTextValue));
        }

        private void ListView_Flights_Refreshing(object sender, EventArgs e)
        {
            PopulateListView(searchService.GetRecentSearches(SearchBar_Flights.Text));
            ListView_Flights.EndRefresh();
        }

        private void ListView_Flights_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Selected", search.Location, "OK");
        }

        private void MenuItem_OnDelete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;
            searchGroups[0].Remove(search);

            searchService.DeleteSearch(search.Id);
        }
    }
}