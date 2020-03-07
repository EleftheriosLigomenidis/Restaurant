using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using FoodApp.Repositories;
using FoodApp.DAL;
using FoodApp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Unity.Injection;
using FoodApp.Controllers;
using Microsoft.AspNet.Identity;
using Unity.Lifetime;
using System.Data.Entity;
using FoodApp.Persistence;

namespace FoodApp
{
    public class Bootstraper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            //This is the important line to edit  
         
            container.RegisterType<IDishRepository, DishRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<AccountController>();
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            container.RegisterType<UserManager<ApplicationUser>>();
            container.RegisterType<DbContext, ApplicationDbContext>();
            container.RegisterType<ApplicationUserManager>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}