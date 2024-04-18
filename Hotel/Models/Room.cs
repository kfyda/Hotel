using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Type { get; set; } // Jednoosobowy, Dwuosobowy, Trzyosobowy

        public Room(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}