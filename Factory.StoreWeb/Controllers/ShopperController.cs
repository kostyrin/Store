using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreServicesModule.Services;
using Factory.StoreWeb.Models;
using Repository.Pattern.UnitOfWork;

namespace Factory.StoreWeb.Controllers
{
    [Authorize]
    public class ShopperController : Controller
    {
        private readonly IShopperService _shopperService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public ShopperController(IShopperService shopperService, IUnitOfWorkAsync unitOfWorkAsync)
        {
            _shopperService = shopperService;
            _unitOfWorkAsync = unitOfWorkAsync;
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
            var shopper = _shopperService.GetShopperById(id);
            ShopperFormModel editShopper = Mapper.Map<Shopper, ShopperFormModel>(shopper);
            if (shopper == null)
            {
                return HttpNotFound();
            }
            return View(editShopper);
        }

        // POST: Shopper/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(ShopperFormModel editShopper)
        {
            try
            {
                Shopper shopperToEdit = Mapper.Map<ShopperFormModel, Shopper>(editShopper);
                _shopperService.Update(shopperToEdit);
                await _unitOfWorkAsync.SaveChangesAsync();
                return RedirectToAction("Index", new { id = editShopper.ShopperId });
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
