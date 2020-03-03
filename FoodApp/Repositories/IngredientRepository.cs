using FoodApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Repositories
{
    public class IngredientRepository :IIngredientRepository
    {
        private readonly ApplicationDbContext _context;

        public IngredientRepository(ApplicationDbContext context)
        {

            context =  _context;

        }
    }
}