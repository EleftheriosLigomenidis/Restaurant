using FoodApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.Repositories
{
    public class ReservationRepository :IReservationRepository
    {
        private readonly ApplicationDbContext _context;

        public ReservationRepository(ApplicationDbContext context)
        {
            context = _context;
        }   
    }
}