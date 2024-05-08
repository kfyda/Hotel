using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public string HotelInfo { get; set; }

        public InfoPage()
        {
            InitializeComponent();
            Title = "O nas";
        
            BindingContext = this;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            // Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
