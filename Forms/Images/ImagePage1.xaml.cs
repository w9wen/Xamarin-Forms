using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage1 : ContentPage
    {
        private int _currentImageId = 1;

        public ImagePage1()
        {
            InitializeComponent();
            LoadImage();
        }

        void LoadImage()
        {
            Image_Gallery.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", _currentImageId)),
                CachingEnabled = false
            };
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //_currentImageId++;
            //LoadImage();
            var button = (Button)sender;
            switch (button.Text)
            {
                case "Previous":
                    _currentImageId--;
                    break;
                case "Next":
                    _currentImageId++;
                    break;
                default:
                    break;
            }
            if (_currentImageId==0)
            {
                _currentImageId = 10;
            }
            if (_currentImageId==11)
            {
                _currentImageId = 1;
            }
            LoadImage();
            //DisplayAlert("Title", ((Button) sender).Text.ToString(), "cancel");
        }
    }
}