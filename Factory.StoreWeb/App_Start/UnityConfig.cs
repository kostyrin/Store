using System;
using System.Data.Entity;
using Factory.StoreDataModule.DataModel;
using Factory.StoreDomainModule.Entities;
using Factory.StoreServicesModule.Services;
using Factory.StoreWeb.Controllers;
using Factory.StoreWeb.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Ef6.Factories;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;

namespace Factory.StoreWeb
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            container
                .RegisterType<IDataContextAsync, StoreContext>(new PerRequestLifetimeManager())
                .RegisterType<IRepositoryProvider, RepositoryProvider>(
                    new PerRequestLifetimeManager(), 
                    new InjectionConstructor(new object[]{new RepositoryFactories()})
                    )
                .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new PerRequestLifetimeManager())
                .RegisterType<IRepositoryAsync<Shopper>, Repository<Shopper>>()
                //.RegisterType<IRepositoryAsync<Product>, Repository<Product>>()
                .RegisterType<IShopperService, ShopperService>()
                .RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>()
                .RegisterType<UserManager<ApplicationUser>>()
                .RegisterType<DbContext, ApplicationDbContext>()
                .RegisterType<ApplicationUserManager>()
                .RegisterType<AccountController>(new InjectionConstructor());
        }
    }
}
