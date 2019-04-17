using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forms.Services
{
    public class SearchService
    {
        private List<Search> _searches = new List<Search>
        {
            new Search
            {
                Id=1,
                Location ="Taipei",
                CheckIn = new DateTime(2019, 4, 17),
                CheckOut =new DateTime(2019,4,20),
            },
            new Search
            {
                Id=2,
                Location="Kaohsiung",
                CheckIn = new DateTime(2019, 4,20),
                CheckOut = new DateTime(2019,4,30),
            },
        };

        public IEnumerable<Search> GetRecentSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
            {
                return _searches;
            }
            return _searches.Where(s => s.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }
        public void DeleteSearch(int searchId)
        {
            _searches.Remove(_searches.Single(s => s.Id == searchId));
        }
    }
}
