using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PriceListPage : ContentPage
    {
        public PriceListPage()
        {
            InitializeComponent();
            Title = "Cennik usługi hotelowej";
        }

        private void ShowInfo(string roomType)
        {
            string message = GetRoomInfo(roomType);
            DisplayAlert("Informacja o pokoju", message, "OK");
        }

        private string GetRoomInfo(string roomType)
        {
            switch (roomType)
            {
                case "Jednoosobowy (doba)":
                    return "Wybrałeś pokój jednoosobowy, którego płatność za dobę wynosi 100 zł.";
                case "Jednoosobowy (doba) + wyżywienie":
                    return "Wybrałeś pokój jednoosobowy z wyżywieniem, którego płatność za dobę wynosi 150 zł.";
                case "Dwuosobowy (doba)":
                    return "Wybrałeś pokój dwuosobowy, którego płatność za dobę wynosi 200 zł.";
                case "Dwuosobowy (doba) + wyżywienie":
                    return "Wybrałeś pokój dwuosobowy z wyżywieniem, którego płatność za dobę wynosi 250 zł.";
                case "Trzyosobowy (doba)":
                    return "Wybrałeś pokój trzyosobowy, którego płatność za dobę wynosi 300 zł.";
                case "Trzyosobowy (doba) + wyżywienie":
                    return "Wybrałeś pokój trzyosobowy z wyżywieniem, którego płatność za dobę wynosi 350 zł.";
                case "Czteroosobowy (doba)":
                    return "Wybrałeś pokój czteroosobowy, którego płatność za dobę wynosi 400 zł.";
                case "Czteroosobowy (doba) + wyżywienie":
                    return "Wybrałeś pokój czteroosobowy z wyżywieniem, którego płatność za dobę wynosi 450 zł.";
                default:
                    return "Nieznany rodzaj pokoju.";
            }
        }

        private void Jednoosobowy_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Jednoosobowy (doba)");
        }

        private void JednoosobowyWyzywienie_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Jednoosobowy (doba) + wyżywienie");
        }

        private void Dwuosobowy_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Dwuosobowy (doba)");
        }

        private void DwuosobowyWyzywienie_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Dwuosobowy (doba) + wyżywienie");
        }

        private void Trzyosobowy_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Trzyosobowy (doba)");
        }

        private void TrzyosobowyWyzywienie_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Trzyosobowy (doba) + wyżywienie");
        }

        private void Czteroosobowy_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Czteroosobowy (doba)");
        }

        private void CzteroosobowyWyzywienie_Clicked(object sender, EventArgs e)
        {
            ShowInfo("Czteroosobowy (doba) + wyżywienie");
        }
    }
}