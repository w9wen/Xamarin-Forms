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
    public partial class UserProfilePage : ContentPage
    {
        private UserService _userService = new UserService();
        public UserProfilePage(int userId)
        {
            BindingContext = _userService.GetUser(userId);
            InitializeComponent();
        }
    }
}