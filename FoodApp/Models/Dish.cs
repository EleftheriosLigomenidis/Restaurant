using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
        public DishType DishType { get; set; }
        public virtual List<Dish> Dishes { get; set; }
        public bool IsPopular { get; set; }

    }
}