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
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(emailEntry.Text))
            {
                await App.Database.SaveUserAsync(new User
                {
                    Name = nameEntry.Text,
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text,
                });

                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }
        }

        //async void registerValidation(object sender, EventArgs e)
        //{

        //}
    }
}
