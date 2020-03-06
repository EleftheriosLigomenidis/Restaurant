using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodApp.Repositories;
namespace FoodApp.DAL
{
    public interface IUnitOfWork
    {
        IReservationRepository Reservations { get; }
        IOrderRepository Orders { get; }

        IIngredientRepository Ingredients { get; }

        ITableRepository Tables { get; }

        IDishRepository Dishes { get; }

        void Complete();
        void Dispose();
    }
}