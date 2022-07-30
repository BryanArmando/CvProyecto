using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace CvProyecto.Views
{
    public partial class AboutPage : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        public AboutPage()
        {
            InitializeComponent();
            imageSources.Add("image1.jpg");
            imageSources.Add("image2.jpg");
            imageSources.Add("image3.jpg");

            imgSlider.Images = imageSources;
        }
        private void Abrir_cv(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CvPage());
        }
    }
}