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

        public RoomsPage()
        {
            InitializeComponent();
            _viewModel = new RoomsViewModel();
            BindingContext = _viewModel;

            var addButton = new Button { Text = "Dodaj pokój" };
            addButton.Clicked += OnAddButtonClicked;

            var listView = new ListView();
            listView.SetBinding(ListView.ItemsSourceProperty, nameof(RoomsViewModel.Rooms));
            listView.ItemTemplate = new DataTemplate(() =>
            {
                var label = new Label();
                label.SetBinding(Label.TextProperty, "Type");
                var deleteButton = new Button { Text = "Usuń" };
                deleteButton.Clicked += OnDeleteButtonClicked;
                return new ViewCell { View = new StackLayout { Children = { label, deleteButton } } };
            });

            Content = new StackLayout
            {
                Children = { addButton, listView }
            };
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var types = new string[] { "Jednoosobowy", "Dwuosobowy", "Trzyosobowy" };
            var type = types[types.Length - 1]; // Domyślnie trzyosobowy
            _viewModel.AddRoom(type);
        }

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var room = (Room)button.BindingContext;

            var result = await DisplayAlert("Usuwanie pokoju", $"Czy na pewno chcesz usunąć pokój {room.Type}?", "Tak", "Anuluj");

            if (result)
            {
                _viewModel.RemoveRoom(room);
            }
        }

        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var selectedRoom = (Room)e.Item;
            await DisplayAlert("Wybrany pokój", $"Wybrano pokój {selectedRoom.Type}", "OK");

            // Odznacz zaznaczony element
            ((ListView)sender).SelectedItem = null;
        }
    }
}