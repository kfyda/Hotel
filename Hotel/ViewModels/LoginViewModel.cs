using Hotel.Models;
using Hotel.Services;
using Hotel.Views;
using MvvmHelpers.Commands;
using Command = MvvmHelpers.Commands.Command;
using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MvvmHelpers;
using System.Linq;
using Xamarin.Essentials;



namespace Hotel.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email, password;
        private List<User> users;


        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        // Zmienna przechowująca tabelę Register (dane użytkownika)
        public ObservableRangeCollection<Register> LoginModel { get; set; }
        public AsyncCommand AddCommand { get; }
        public Command LoginCommand { get; set; }
        public Command GoToRegisterCommand { get; }

        IUserService userService;

        public LoginViewModel()
        {
            Title = "Logowanie";
            LoginModel = new ObservableRangeCollection<Register>();
            //AddCommand = new AsyncCommand(Login);
            LoginCommand = new Command(OnLoginClicked);
            GoToRegisterCommand = new Command(OnRegisterClicked);
            userService = DependencyService.Get<IUserService>();
        }



        // Zmień tutaj (wyświetlenie rekordów tabeli użytkownika)

        async Task UserGet()
        {
            //users = await App.Database.GetPeopleAsync();
        }

        //async Task Login()
        //{
        //    LoginModel;
        //}
        private async void OnLoginClicked(object obj)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                DependencyService.Get<IToast>()?.MakeToast("Wprowadź wszystkie dane!");
                return;
            }

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void OnRegisterClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
        }
    }
}
