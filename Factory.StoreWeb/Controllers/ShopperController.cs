using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreServicesModule.Services;
using Factory.StoreWeb.Models;

namespace Factory.StoreWeb.Controllers
{
    public class ShopperController : Controller
    {
        private readonly IShopperService _shopperService;

        public ShopperController(IShopperService shopperService)
        {
            _shopperService = shopperService;
        }
        // GET: Shopper
        public ViewResult Index()
        {
            var shoppers = _shopperService.GetShoppers();
            var shoppersDetails = Mapper.Map<IEnumerable<Shopper>, IEnumerable<ShopperViewModel>>(shoppers);
            return View(shoppersDetails);
        }

        // GET: Shopper/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shopper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shopper/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shopper/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shopper/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shopper/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shopper/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
