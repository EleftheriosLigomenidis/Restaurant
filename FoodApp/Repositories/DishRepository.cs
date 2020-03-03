using FoodApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Repositories
{
    public class DishRepository :IDishRepository
    {
        private readonly ApplicationDbContext _context;

        public DishRepository(ApplicationDbContext context)
        {
            context = _context;
        }
    }
}