using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Models
{
    public class Reservation : iCountable
    {
        public int ReservationId { get; set; }
        public string ReservationName { get; set; }
        public DateTime ReservationTime { get; set; }

        public int Capacity { get; set; }

        public int TableId { get; set; }
        public virtual  Table Table { get; set; }

    }
}