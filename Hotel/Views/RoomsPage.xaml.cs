using Hotel.Models;
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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomsPage : ContentPage
    {
        private readonly RoomsViewModel _viewModel;
        private Xamarin.Forms.Picker picker;
        private ObservableCollection<Room> selectedRooms = new ObservableCollection<Room>(); // Lista wybranych pokojów
        private double totalPrice = 0; // Całkowita cena za wszystkie wybrane pokoje
        private Label totalLabel; // Deklaracja etykiety totalLabel
        private const int MaxRoomSelection = 5; // Maksymalna liczba wybranych pokoi
        private Xamarin.Forms.ListView summaryListView; // Deklaracja listy wybranych pokojów
        private DatePicker datePicker; // Dodany komponent DatePicker

        public RoomsPage()
        {
            InitializeComponent();
            _viewModel = new RoomsViewModel();
            BindingContext = _viewModel;
            Title = "Pokoje";

            var addButton = new Button { Text = "Dodaj pokój", BackgroundColor = Color.Green, TextColor = Color.White };
            addButton.Clicked += OnAddButtonClicked;

            picker = new Xamarin.Forms.Picker
            {
                Title = "Wybierz rodzaj pokoju",
                Items = { "Jednoosobowy (doba) - 100 zł", "Jednoosobowy (doba) + wyżywienie - 150 zł", "Dwuosobowy (doba) - 200 zł", "Dwuosobowy (doba) + wyżywienie - 250 zł", "Trzyosobowy (doba) - 300 zł", "Trzyosobowy (doba) + wyżywienie - 350 zł", "Czteroosobowy (doba) - 400 zł", "Czteroosobowy (doba) + wyżywienie - 450 zł" }
            };

            datePicker = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now,
                MaximumDate = DateTime.Now.AddYears(1), // Ograniczenie wyboru daty do jednego roku od dzisiaj
                Date = DateTime.Now // Ustawienie domyślnej daty na dzisiaj
            };

            var listView = new Xamarin.Forms.ListView();
            listView.SetBinding(Xamarin.Forms.ListView.ItemsSourceProperty, nameof(RoomsViewModel.Rooms));
            listView.ItemTemplate = new DataTemplate(() =>
            {
                var label = new Label();
                label.SetBinding(Label.TextProperty, "Type");

                var deleteButton = new Button { Text = "Usuń", BackgroundColor = Color.Red, TextColor = Color.White };
                deleteButton.Clicked += OnDeleteButtonClicked;

                var selectButton = new Button { Text = "Opis", BackgroundColor = Color.Black, TextColor = Color.White };
                selectButton.Clicked += OnSelectButtonClicked;

                var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Padding = new Thickness(10, 5) };
                layout.Children.Add(label);
                layout.Children.Add(new BoxView { HorizontalOptions = LayoutOptions.FillAndExpand });
                layout.Children.Add(deleteButton);
                layout.Children.Add(selectButton);

                return new ViewCell { View = layout };
            });

            var summaryLabel = new Label { Text = "Wybrane pokoje:", FontAttributes = FontAttributes.Bold, Margin = new Thickness(10, 5) };
            summaryListView = new Xamarin.Forms.ListView(); // Inicjalizacja listy wybranych pokojów
            summaryListView.ItemTemplate = new DataTemplate(() =>
            {
                var roomLabel = new Label();
                var dateLabel = new Label(); // Dodanie etykiety na datę rezerwacji

                roomLabel.SetBinding(Label.TextProperty, "Type");
                dateLabel.SetBinding(Label.TextProperty, "ReservationDate", stringFormat: "Data rezerwacji: {0:D}"); // Formatowanie daty na tekst

                var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Padding = new Thickness(10, 5) };
                layout.Children.Add(roomLabel);
                layout.Children.Add(new BoxView { HorizontalOptions = LayoutOptions.FillAndExpand });
                layout.Children.Add(dateLabel); // Dodanie etykiety z datą rezerwacji

                return new ViewCell { View = layout };
            });

            totalLabel = new Label { Text = "Całkowita cena: 0 zł", FontAttributes = FontAttributes.Bold, Margin = new Thickness(10, 5) }; // Inicjalizacja etykiety totalLabel

            var orderButton = new Button { Text = "Zamów i zapłać", BackgroundColor = Color.Blue, TextColor = Color.White };
            orderButton.Clicked += OnOrderButtonClicked;

            Content = new StackLayout
            {
                Children = { addButton, picker, datePicker, new BoxView { HeightRequest = 1, Color = Color.Gray }, listView, summaryLabel, summaryListView, totalLabel, orderButton }
            };
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            if (selectedRooms.Count >= MaxRoomSelection)
            {
                DisplayAlert("Ostrzeżenie", $"Możesz wybrać maksymalnie {MaxRoomSelection} kombinacji pokoi na jedno konto.", "OK");
                return;
            }

            var selectedOption = picker.SelectedItem as string;
            var price = GetPrice(selectedOption);
            totalPrice += price;

            // Pobranie daty rezerwacji z komponentu DatePicker
            var reservationDate = datePicker.Date;

            var room = new Room(1, selectedOption, reservationDate); // Dodanie wybranej daty do nowego pokoju
            _viewModel.AddRoom(selectedOption, reservationDate); // Przekazanie daty rezerwacji do metody AddRoom
            selectedRooms.Add(room);

            UpdateTotalPrice(); // Aktualizacja całkowitej ceny po dodaniu pokoju

            // Aktualizacja wyświetlanych pokojów po dodaniu pokoju
            selectedRooms = new ObservableCollection<Room>(_viewModel.Rooms.Where(r => r.ReservationDate != DateTime.MinValue));
            summaryListView.ItemsSource = selectedRooms; // Aktualizacja widoku listy
        }



        private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var room = (Room)button.BindingContext;

            var result = await DisplayAlert("Usuwanie pokoju", $"Czy na pewno chcesz usunąć pokój {room.Type}?", "Tak", "Anuluj");

            if (result)
            {
                // Odejmowanie ceny pokoju od całkowitej ceny
                var price = GetPrice(room.Type);
                totalPrice -= price;

                // Usuwanie pokoju z widoku ListView
                _viewModel.RemoveRoom(room);

                // Usuwanie pokoju z listy wybranych pokojów
                selectedRooms.Remove(room);

                // Aktualizacja całkowitej ceny
                UpdateTotalPrice();

                // Aktualizacja wyświetlanych pokojów
                selectedRooms = new ObservableCollection<Room>(_viewModel.Rooms.Where(r => r.ReservationDate != DateTime.MinValue));
                summaryListView.ItemsSource = selectedRooms; // Aktualizacja widoku listy
            }
        }




        private async void OnSelectButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var room = (Room)button.BindingContext;

            await DisplayAlert("Wybrany pokój", $"Wybrano pokój {room.Type}", "OK");
        }

        private async void OnOrderButtonClicked(object sender, EventArgs e)
        {
            // Tutaj możesz dodać kod obsługi zamówienia i płatności
            await DisplayAlert("Zamówienie złożone", $"Twoje zamówienie zostało pomyślnie złożone. Całkowita cena: {totalPrice} zł", "OK");
        }

        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var selectedRoom = (Room)e.Item;
            await DisplayAlert("Wybrany pokój", $"Wybrano pokój {selectedRoom.Type}", "OK");

            ((Xamarin.Forms.ListView)sender).SelectedItem = null;
        }

        private void UpdateTotalPrice()
        {
            totalLabel.Text = $"Całkowita cena: {totalPrice} zł"; // Aktualizacja wyświetlanej całkowitej ceny
        }

        private double GetPrice(string roomType)
        {
            // Pobieranie ceny na podstawie rodzaju pokoju
            switch (roomType)
            {
                case "Jednoosobowy (doba) - 100 zł":
                    return 100;
                case "Jednoosobowy (doba) + wyżywienie - 150 zł":
                    return 150;
                case "Dwuosobowy (doba) - 200 zł":
                    return 200;
                case "Dwuosobowy (doba) + wyżywienie - 250 zł":
                    return 250;
                case "Trzyosobowy (doba) - 300 zł":
                    return 300;
                case "Trzyosobowy (doba) + wyżywienie - 350 zł":
                    return 350;
                case "Czteroosobowy (doba) - 400 zł":
                    return 400;
                case "Czteroosobowy (doba) + wyżywienie - 450 zł":
                    return 450;
                default:
                    return 0;
            }
        }
    }
}