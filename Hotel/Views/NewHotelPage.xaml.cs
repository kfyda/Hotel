using Hotel.Models;
using Hotel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;


namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewHotelPage : ContentPage
    {
        List<Hotels> hotelList = new List<Hotels>();
        public NewHotelPage()
        {
            InitializeComponent();

            Title = "Dodaj nowy hotel";
            GetHotels();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionHotel.ItemsSource = await App.Database.GetHotelAsync();
        }
        async void CoordHotel(object sender, EventArgs e)
        {
            try
            {
                await Geocoding.GetLocationsAsync(streetEntry.Text + " " + streetNrEntry.Text + ", " + cityEntry.Text).ContinueWith(t =>
                {
                    var locations = t.Result;

                    var location = locations.First();
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        latitude.Text = location.Latitude.ToString();
                        longitude.Text = location.Longitude.ToString();
                    });
                });
            }
            catch
            { DisplayActionSheet("Nie znaleziono lokalizacji", "OK", null); }
        }

        async void AddHotel(object sender, EventArgs e)
        {
            try
            {
                await App.Database.SaveHotelAsync(new Hotels
                {
                    Name = nameEntry.Text,
                    City = cityEntry.Text,
                    Street = streetEntry.Text,
                    StreetNr = streetNrEntry.Text,
                    Latitude = double.Parse(latitude.Text),
                    Longitude = double.Parse(longitude.Text)
                });

                // Resetowanie pól po pomyślnym dodaniu
                nameEntry.Text = cityEntry.Text = streetEntry.Text = streetNrEntry.Text = latitude.Text = longitude.Text = string.Empty;

                // Wyświetlenie alertu
                await DisplayAlert("Sukces", "Prawidłowo dodano nowy hotel, możesz sprawdzić go na mapie!", "OK");
            }
            catch
            {
                // Wyświetlenie alertu w przypadku niepowodzenia
                await DisplayAlert("Błąd", "Nie udało się dodać hotelu", "OK");
            }
        }

        async void DeleteHotel(object sender, EventArgs e)
        {
            var hotelToDelete = (Hotels)hotelEntry.SelectedItem;
            await App.Database.DeleteHotelAsync(hotelToDelete);
            hotelEntry.SelectedItem = null;
        }
        private async void GetHotels()
        {
            hotelList = await App.Database.GetHotelAsync();
            hotelEntry.ItemsSource = hotelList;
        }
    }
}