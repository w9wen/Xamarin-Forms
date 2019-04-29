using Forms.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RESTfulPage : ContentPage
    {

        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;
        public RESTfulPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
            ListView_Posts.ItemsSource = _posts;
            base.OnAppearing();

        }

        private async void Button_Add_Clicked(object sender, EventArgs e)
        {
            var post = new Post { Title = "Title " + DateTime.Now.ToString("yyyy-MM-dd") };
            _posts.Insert(0, post);
            var content = JsonConvert.SerializeObject(post);
            await _client.PostAsync(Url, new StringContent(content));
        }

        private async void Button_Update_Clicked(object sender, EventArgs e)
        {
            var post = _posts[0];
            post.Title += " UPDATED";
            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        private async void Button_Delete_Clicked(object sender, EventArgs e)
        {
            var post = _posts[0];
            _posts.Remove(post);
            await _client.DeleteAsync(Url + "/" + post.Id);
        }
    }
}