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
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            PhoneNumber = "123456789";
            StreetName = "Jagiellońska 1";
            CompanyName = "Hotel-Kamilos";
        }
        public string PhoneNumber { get; set; }
        public string StreetName { get; set; }
        public string CompanyName { get; set; }
        public ICommand OpenWebCommand { get; }
    }
}