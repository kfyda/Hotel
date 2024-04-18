using Hotel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetUserAsync();
        }

        private async void OnClickedLogin(object sender, EventArgs e)
        {
            // Pobierz użytkownika z bazy danych na podstawie wprowadzonego adresu e-mail
            var users = await App.Database.GetUserAsync();

            // Sprawdź, czy istnieje użytkownik o podanym adresie e-mail
            var user = users.FirstOrDefault(u => u.Email == emailEntry.Text);

            if (user != null)
            {
                // Jeśli użytkownik istnieje, sprawdź poprawność hasła
                if (user.Password == passwordEntry.Text)
                {
                    // Jeśli hasło jest poprawne, przejdź do następnej strony (np. AboutPage)
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
                else
                {
                    // Jeśli hasło jest niepoprawne, wyświetl komunikat
                    await DisplayAlert("Błąd logowania", "Niepoprawne hasło", "OK");
                }
            }
            else
            {
                // Jeśli użytkownik o podanym adresie e-mail nie istnieje, wyświetl komunikat
                await DisplayAlert("Błąd logowania", "Użytkownik o podanym adresie e-mail nie istnieje", "OK");
            }
        }

    }
}