using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Models
{
    public class Table : iCountable
    {
        public int TableId { get; set; }
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }

        public int MyProperty { get; set; }


    }
}