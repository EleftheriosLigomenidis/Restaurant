using FoodApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Repositories
{
    public class TableRepository :ITableRepository
    {
        private readonly ApplicationDbContext _context;


        public TableRepository(  ApplicationDbContext context)
        {
            context = _context;

        }
    }
}