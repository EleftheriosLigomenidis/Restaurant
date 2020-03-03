using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public double TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public  virtual ICollection<Dish> Dishes { get; set; }
    }
}