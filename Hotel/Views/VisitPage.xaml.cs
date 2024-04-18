using Hotel.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    public partial class VisitPage : ContentPage
    {
        VisitViewModel _viewModel;

        public VisitPage()
        {
            InitializeComponent();
            Title = "Wizyty";
            BindingContext = _viewModel = new VisitViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
