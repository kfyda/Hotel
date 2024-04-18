using Hotel.Models;
using Hotel.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hotel.ViewModels
{
    public class VisitViewModel : BaseViewModel
    {
        private Visit _selectedItem;
        public ObservableCollection<Visit> Visit { get; }
        public Command LoadVisitCommand { get; }
        public Command AddVisitCommand { get; }
        //public Command<Visit> VisitTapped { get; }

        public VisitViewModel()
        {
            Visit = new ObservableCollection<Visit>();
            LoadVisitCommand = new Command(async () => await ExecuteLoadVisitCommand());

            //ItemTapped = new Command<Visit>(OnItemSelected);
            AddVisitCommand = new Command(OnAddVisit);
        }

        async Task ExecuteLoadVisitCommand()
        {
            IsBusy = true;

            try
            {
                Visit.Clear();
                var visits = await DataStore.GetItemsAsync(true);
                foreach (var visit in visits)
                {
                    Visit.Add(visit);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Visit SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                //OnItemSelected(value);
            }
        }

        private async void OnAddVisit(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewVisitPage));
        }

        //async void OnItemSelected(Visit item)
        //{
        //    if (item == null)
        //        return;

        //    // This will push the ItemDetailPage onto the navigation stack
        //    await Shell.Current.GoToAsync($"{nameof(VisitDetailPage)}?{nameof(VisitDetailViewModel.ItemId)}={item.Id}");
        //}
    }
}