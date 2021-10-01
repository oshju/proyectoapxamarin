using System.ComponentModel;
using Xamarin.Forms;
using proyectouno.ViewModels;

namespace proyectouno.Views
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
