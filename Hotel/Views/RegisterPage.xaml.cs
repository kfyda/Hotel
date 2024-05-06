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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.BindingContext = new RegisterViewModel();
        }

        private async void OnClickRegister(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) &&
                !string.IsNullOrWhiteSpace(emailEntry.Text) &&
                !string.IsNullOrWhiteSpace(passwordEntry.Text) &&
                !string.IsNullOrWhiteSpace(confirmEntry.Text))
            {
                if (passwordEntry.Text != confirmEntry.Text)
                {
                    await DisplayAlert("Błąd", "Hasła nie pasują do siebie.", "OK");
                    return;
                }

                await App.Database.SaveUserAsync(new User
                {
                    Name = nameEntry.Text,
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text,
                });

                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }
            else
            {
                await DisplayAlert("Błąd", "Wszystkie pola muszą być wypełnione.", "OK");
            }
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            passwordEntry.IsPassword = !e.Value;
        }
    }
}
