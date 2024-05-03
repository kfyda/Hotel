using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Hotel.Models
{
    public class Hotels
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNr { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}