using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Models
{
    public class Ingredient : iCountable
    {
        public int IngredientId { get; set; }
        public int Capacity { get; set; }

        public string IngredientName { get; set; }

        public  virtual ICollection<Dish> Dishes { get; set; }

    }
}