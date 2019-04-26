using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileSystemPage : ContentPage
    {
        //private const string _templateFileName = "XamarinFormsTemplateFile.txt";
        private const string _localFileName = "XamarinFormsLocalFile.txt";
        private static string _localPath = Path.Combine(FileSystem.AppDataDirectory, _localFileName);
        public string CurrentContent { get; set; }
        public FileSystemPage()
        {
            InitializeComponent();
        }

        private async void Button_FileOpen_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(_localPath))
            {
                var currentContents = File.ReadAllText(_localPath);
                await DisplayAlert("Local File", $"{_localPath} \n {currentContents}", "OK");
            }
            else
            {
                //using (var stream = await FileSystem.OpenAppPackageFileAsync(_localFileName))
                //{

                //}

                File.WriteAllText(_localPath, "這是測試喔");
            }
        }
    }
}