using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;


namespace Hotel.Models
{
    public class Visit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ServiceType { get; set; }
        public DateTime VisitDate { get; set; }

        [ForeignKey(nameof(UserId))]
        public User user { get; set; }
    }
}