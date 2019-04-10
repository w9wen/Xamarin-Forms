using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms.Images
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //var imageSrouce = (UriImageSource)ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7/"));
            ////var imageSource = new UriImageSource { Uri = new Uri ("http://lorempixel.com/1920/1080/sports/7/") };
            //imageSrouce.CachingEnabled = false;
            ////imageSource.CacheValidity = TimeSpan.FromHours(10);

            //Image_Sport.Source = imageSrouce;
            ////Image_Sport.Source = "http://lorempixel.com/1920/1080/sports/7/";

            ////Image_Sport.Aspect = Aspect.AspectFill;

            Image_Sport.Source = ImageSource.FromResource("Forms.Images.background.jpg");
        }
    }
}
