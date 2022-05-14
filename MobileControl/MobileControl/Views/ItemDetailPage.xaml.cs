using MobileControl.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileControl.Views
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