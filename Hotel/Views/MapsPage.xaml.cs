using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();

            Title = "Hotel u Kamila";

            // Utwórz mapę
            Xamarin.Forms.Maps.Map map = new Xamarin.Forms.Maps.Map
            {
                IsShowingUser = true,
                MoveToLastRegionOnLayoutChange = false
            };

            // Zdefiniuj współrzędne geograficzne dla Nowego Sącza
            double newSaczLatitude = 49.6225; // Szerokość geograficzna
            double newSaczLongitude = 20.7147; // Długość geograficzna

            // Utwórz punkt na mapie dla Nowego Sącza
            Pin pin = new Pin
            {
                Label = "Nowy Sącz",
                Address = "ul. Bolesława Limanowskiego 1, Nowy Sącz", // Adres
                Type = PinType.Place,
                Position = new Position(newSaczLatitude, newSaczLongitude) // Ustawienie współrzędnych geograficznych
            };

            pin.Clicked += async (sender, e) =>
            {
                try
                {
                    var currentLocation = await Geolocation.GetLastKnownLocationAsync();
                    if (currentLocation != null)
                    {
                        var placemarks = await Geocoding.GetPlacemarksAsync(currentLocation.Latitude, currentLocation.Longitude);
                        var placemark = placemarks?.FirstOrDefault();
                        if (placemark != null)
                        {
                            var locationUri = $"https://www.google.com/maps/dir/{placemark.FeatureName},{placemark.Thoroughfare},{placemark.SubThoroughfare},{placemark.Locality},{placemark.AdminArea}";
                            await Launcher.OpenAsync(new Uri(locationUri));
                        }
                        else
                        {
                            await DisplayAlert("Błąd", "Nie można uzyskać adresu dla aktualnych współrzędnych.", "OK");
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
