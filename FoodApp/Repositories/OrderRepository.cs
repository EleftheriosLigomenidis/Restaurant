using FoodApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Repositories
{
    public class OrderRepository :IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(  ApplicationDbContext context)
        {
            context = _context;
        }
    }
}