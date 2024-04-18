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

        public void AddRoom(string type)
        {
            int id = Rooms.Any() ? Rooms.Max(r => r.Id) + 1 : 1;
            Rooms.Add(new Room(id, type));
        }

        public void RemoveRoom(Room room)
        {
            Rooms.Remove(room);
        }
    }
}