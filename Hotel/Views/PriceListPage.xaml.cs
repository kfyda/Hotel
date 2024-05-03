using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PriceListPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public Dictionary<string, string> RoomDescriptions { get; set; }

        public PriceListPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Jednoosobowy (doba)",
                "Jednoosobowy (doba) + wyżywienie",
                "Dwuosobowy (doba)",
                "Dwuosobowy (doba) + wyżywienie",
                "Trzyosobowy (doba)",
                "Trzyosobowy (doba) + wyżywienie",
                "Czteroosobowy (doba)",
                "Czteroosobowy (doba) + wyżywienie"
            };

            RoomDescriptions = new Dictionary<string, string>
            {
                { "Jednoosobowy (doba)", "Wybrałeś pokój jednoosobowy, którego płatność za dobę wynosi 100 zł." },
                { "Jednoosobowy (doba) + wyżywienie", "Wybrałeś pokój jednoosobowy z wyżywieniem, którego płatność za dobę wynosi 150 zł." },
                { "Dwuosobowy (doba)", "Wybrałeś pokój dwuosobowy, którego płatność za dobę wynosi 200 zł." },
                { "Dwuosobowy (doba) + wyżywienie", "Wybrałeś pokój dwuosobowy z wyżywieniem, którego płatność za dobę wynosi 250 zł." },
                { "Trzyosobowy (doba)", "Wybrałeś pokój trzyosobowy, którego płatność za dobę wynosi 300 zł." },
                { "Trzyosobowy (doba) + wyżywienie", "Wybrałeś pokój trzyosobowy z wyżywieniem, którego płatność za dobę wynosi 350 zł." },
                { "Czteroosobowy (doba)", "Wybrałeś pokój czteroosobowy, którego płatność za dobę wynosi 400 zł." },
                { "Czteroosobowy (doba) + wyżywienie", "Wybrałeś pokój czteroosobowy z wyżywieniem, którego płatność za dobę wynosi 450 zł." }
            };

            MyListView.ItemsSource = Items;
            Title = "Cennik Hotelowy";

            // Dodanie przycisku "Zobacz" obok każdego elementu listy
            MyListView.ItemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var label = new Label();
                var button = new Button();

                label.SetBinding(Label.TextProperty, new Binding("."));
                label.HorizontalOptions = LayoutOptions.StartAndExpand;
                label.TextColor = Color.White; // Ustawienie koloru tekstu na biały
                label.Margin = new Thickness(20, 0, 0, 0); // Dodanie marginesu do etykiety

                button.Text = "Zobacz";
                button.BackgroundColor = Color.Blue;
                button.TextColor = Color.White;
                button.Margin = new Thickness(20, 0, 0, 0); // Dodanie marginesu do przycisku
                button.Clicked += async (sender, e) =>
                {
                    var clickedButton = (Button)sender; // Pobranie klikniętego przycisku
                    if (clickedButton.Text == "Zobacz") // Sprawdzenie czy kliknięty przycisk to "Zobacz"
                    {
                        var roomType = label.Text;
                        if (RoomDescriptions.ContainsKey(roomType))
                        {
                            await DisplayAlert(roomType, RoomDescriptions[roomType], "OK");
                        }
                        else
                        {
                            await DisplayAlert("Błąd", "Nie można znaleźć opisu dla wybranego pokoju.", "OK");
                        }
                    }
                };

                grid.Children.Add(label);
                grid.Children.Add(button, 1, 0);

                return new ViewCell { View = grid };
            });

            // Dodanie obsługi zdarzenia ItemTapped
            MyListView.ItemTapped += Handle_ItemTapped;
        }

        // Metoda obsługująca zdarzenie ItemTapped
        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null || !(e.Item is string roomType))
                return;

            if (RoomDescriptions.ContainsKey(roomType))
            {
                await DisplayAlert(roomType, RoomDescriptions[roomType], "OK");
            }
            else
            {
                await DisplayAlert("Błąd", "Nie można znaleźć opisu dla wybranego pokoju.", "OK");
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
