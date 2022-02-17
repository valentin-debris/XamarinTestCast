using System.ComponentModel;
using TestCast.ViewModels;
using Xamarin.Forms;

namespace TestCast.Views
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