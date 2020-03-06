using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodApp.DAL;
namespace FoodApp.Controllers
{
    public class DishController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DishController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Dish
        public ActionResult Index()
        {
            _unitOfWork.Complete();
            return RedirectToAction("Index","Home");
        }
    }
}