using Hotel.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Hotel.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Strona główna";
            OpenWebCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(NewVisitPage)));
        }

        public ICommand OpenWebCommand { get; }
    }
}