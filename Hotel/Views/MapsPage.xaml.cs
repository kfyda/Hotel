using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Geolocator;
using Hotel.Models;

namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
            Title = "Gdzie znajdują się nasze hotele?";
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ResetMapAsync(); // Resetujemy mapę przy pojawieniu się strony
        }

        private async Task ResetMapAsync()
        {
            var hotels = await App.Database.GetHotelAsync();

            // Utwórz mapę
            Xamarin.Forms.Maps.Map map = new Xamarin.Forms.Maps.Map
            {
                IsShowingUser = true,
                MoveToLastRegionOnLayoutChange = false
            };

            // Punkt startowy na bieżącą lokalizację
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(position.Latitude, position.Longitude), Distance.FromKilometers(1)));

            foreach (var hotel in hotels)
            {
                string address = hotel.City + " " + hotel.Street + " " + hotel.StreetNr;
                // Utworzenie punktu na mapie
                Pin pin = new Pin
                {
                    Label = hotel.Name,
                    Address = address,
                    Type = PinType.Place,
                    Position = new Position(hotel.Latitude, hotel.Longitude)
                };

                pin.MarkerClicked += async (sender, e) =>
                {
                    try
                    {
                        var currentLocation = await Geolocation.GetLastKnownLocationAsync();
                        if (currentLocation != null)
                        {
                            var currentPlacemarks = await Geocoding.GetPlacemarksAsync(currentLocation.Latitude, currentLocation.Longitude);
                            var currentPlacemark = currentPlacemarks?.FirstOrDefault();

                            var pinPlacemarks = await Geocoding.GetPlacemarksAsync(pin.Position.Latitude, pin.Position.Longitude);
                            var pinPlacemark = pinPlacemarks?.FirstOrDefault();

                            if (currentPlacemark != null && pinPlacemark != null)
                            {
                                var currentAddress = $"{currentPlacemark.FeatureName},{currentPlacemark.SubThoroughfare},{currentPlacemark.Thoroughfare},{currentPlacemark.Locality},{currentPlacemark.AdminArea}";
                                var pinAddress = $"{pinPlacemark.FeatureName},{pinPlacemark.SubThoroughfare},{pinPlacemark.Thoroughfare},{pinPlacemark.Locality},{pinPlacemark.AdminArea}";

                                var locationUri = $"https://www.google.com/maps/dir/{Uri.EscapeDataString(currentAddress)}/{Uri.EscapeDataString(pinAddress)}";
                                await Launcher.OpenAsync(new Uri(locationUri));
                            }
                            else
                            {
                                await DisplayAlert("Błąd", "Nie można uzyskać adresu dla jednego z punktów.", "OK");
                            }
                        }
                        else
                        {
                            await DisplayAlert("Błąd", "Nie można uzyskać aktualnych współrzędnych.", "OK");
                        }
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("Błąd", $"Wystąpił błąd: {ex.Message}", "OK");
                    }
                };
                // Dodaj punkt do mapy
                map.Pins.Add(pin);
            }

            // Ustaw mapę jako zawartość strony
            Content = new StackLayout
            {
                Children = { map }
            };
        }

        async void Map_MapClicked(object sender, MapClickedEventArgs e)
        {
            // Wyświetl alert z koordynatami kliknięcia na mapie
            await DisplayAlert("Koordynaty", $"Lat: {e.Position.Latitude}, Long: {e.Position.Longitude}", "OK");
        }
    }
}
