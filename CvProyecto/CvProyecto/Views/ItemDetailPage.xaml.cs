using CvProyecto.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CvProyecto.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}