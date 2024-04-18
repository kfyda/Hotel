using Hotel.Models;
using Hotel.Views;
using Hotel.Services;
using MvvmHelpers.Commands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;


namespace Hotel.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private string name, email, password, confirmPassword;
        public string Name { get => name; set => SetProperty(ref name, value); }
        public string Email { get => email; set => SetProperty(ref email, value); }
        public string Password { get => password; set => SetProperty(ref password, value); }
        public string ConfirmPassword { get => confirmPassword; set => SetProperty(ref confirmPassword, value); }
        public ObservableRangeCollection<Register> Register { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public Command RegisterCommand { get; private set; }
        public Command GoToLoginCommand { get; }

        IUserService userService;

        public RegisterViewModel()
        {
            Title = "Rejestracja";
            Register = new ObservableRangeCollection<Register>();
            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RegisterCommand = new Command(OnRegisterClicked);
            GoToLoginCommand = new Command(OnLoginClicked);
            userService = DependencyService.Get<IUserService>();
        }

        async Task Add()
        {
            //if (string.IsNullOrEmpty(name) ||
            //    string.IsNullOrEmpty(email) ||
            //    string.IsNullOrEmpty(password) ||
            //    string.IsNullOrEmpty(password))
            //{
            //    //DependencyService.Get<IToast>()?.MakeToast("Wprowadź wszystkie dane!");
            //    return;
            //}
            //if (password != confirmPassword)
            //{
            //    //DependencyService.Get<IToast>()?.MakeToast("Powtórzone hasło nie jest takie same!");
            //    return;
            //}

            //await userService.AddUser(name, email, password);
            //await Refresh();
            //if (!string.IsNullOrWhiteSpace(name))
            //{
            //    await App.Database.SavePersonAsync(new User
            //    {
            //        Name = name,
            //        Email = email,
            //        Password = password,
            //    });
            //}
        }
        private async void OnRegisterClicked(object obj)
        {
            await Add();
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
        private async void OnLoginClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        async Task Refresh()
        {
            IsBusy = true;

#if DEBUG
            await Task.Delay(500);
#endif

            Register.Clear();

            var users = await userService.GetUser();

            Register.AddRange(users);

            IsBusy = false;

            DependencyService.Get<IToast>()?.MakeToast("Refreshed!");
        }
    }
}