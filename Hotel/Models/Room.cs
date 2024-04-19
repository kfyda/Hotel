using System;

namespace Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Type { get; set; } // Jednoosobowy, Dwuosobowy, Trzyosobowy
        public DateTime ReservationDate { get; set; } // Data rezerwacji

        public Room(int id, string type, DateTime reservationDate)
        {
            Id = id;
            Type = type;
            ReservationDate = reservationDate;
        }
    }
}
