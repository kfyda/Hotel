using System;

namespace Hotel.Models
{
    public class RoomWithDate
    {
        public Room Room { get; set; }
        public DateTime SelectedDate { get; set; }

        public RoomWithDate(Room room, DateTime selectedDate)
        {
            Room = room;
            SelectedDate = selectedDate;
        }
    }
}
