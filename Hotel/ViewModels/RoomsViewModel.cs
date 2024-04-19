using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Linq;


namespace Hotel.ViewModels
{
    public class RoomsViewModel : BindableObject
    {
        private ObservableCollection<Room> _rooms;

        public ObservableCollection<Room> Rooms
        {
            get { return _rooms; }
            set
            {
                _rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }

        public RoomsViewModel()
        {
            Rooms = new ObservableCollection<Room>();
        }

        public void AddRoom(string type, DateTime reservationDate)
        {
            int id = Rooms.Count + 1; // Automatyczne przypisywanie ID
            var room = new Room(id, type, reservationDate); // Utworzenie nowego pokoju z datą rezerwacji
            Rooms.Add(room); // Dodanie pokoju do listy
        }

        public void RemoveRoom(Room room)
        {
            Rooms.Remove(room);
        }
    }
}