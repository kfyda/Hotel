﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Hotel.Models
{
    public class ServiceType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}