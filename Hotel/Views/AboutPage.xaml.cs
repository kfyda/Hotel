using Hotel.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private async void OnContactButtonClicked(object sender, EventArgs e)
        {
            // Pobierz ViewModel dla strony głównej
            var viewModel = (AboutViewModel)BindingContext;

            // Wyświetl okno dialogowe z danymi kontaktowymi
            await DisplayAlert("Kontakt", $"Nazwa hotelu: {viewModel.CompanyName}\nNumer telefonu: {viewModel.PhoneNumber}\nAdres e-mail: {viewModel.EmailAddress}\nUlica: {viewModel.StreetName}", "OK");
        }
    }
}
