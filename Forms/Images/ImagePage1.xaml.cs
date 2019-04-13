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

        void Previous_Clicked(object sender, System.EventArgs e)
        {
            _currentImageId--;
            LoadImage();
        }

        void Next_Clicked(object sender, System.EventArgs e)
        {
            _currentImageId++;
            LoadImage();
        }
    }
}