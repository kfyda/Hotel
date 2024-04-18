using Hotel.ViewModels;
using Hotel.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Hotel
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewVisitPage), typeof(NewVisitPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
