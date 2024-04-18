using Hotel.Models;
using Hotel.Services;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;

namespace Hotel.ViewModels
{
    public class NewVisitViewModel : BaseViewModel
    {
        private int userId;
        private string serviceType;
        private DateTime visitDate;

        public NewVisitViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return userId == null
                && !String.IsNullOrWhiteSpace(serviceType)
                && visitDate == null;
        }

        public int UserId
        {
            get => userId;
            set => SetProperty(ref userId, value);
        }

        public string ServiceType
        {
            get => serviceType;
            set => SetProperty(ref serviceType, value);
        }
        public DateTime VisitDate
        {
            get => visitDate;
            set => SetProperty(ref visitDate, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Visit newVisit = new Visit()
            {
                ServiceType = serviceType,
                VisitDate = visitDate,
            };

            await DataStore.AddVisitAsync(newVisit);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}