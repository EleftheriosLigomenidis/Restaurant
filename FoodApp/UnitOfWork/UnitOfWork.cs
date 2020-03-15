using FoodApp.Persistence;
using FoodApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodApp.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IDishRepository Dishes { get; set; }
        public IOrderRepository Orders { get; set; }

        public IIngredientRepository Ingredients { get; set; }

        public ITableRepository Tables { get; set; }

        public IReservationRepository Reservations { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            context = _context;
            Orders = new OrderRepository(context);
            Reservations = new ReservationRepository(context);
            Tables = new TableRepository(context);
            Dishes = new DishRepository(context);
            Ingredients = new IngredientRepository(context);

          
            
        }

        public void Complete()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}