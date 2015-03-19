using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreServicesModule.Services;
using Factory.StoreWeb.Models;
using Factory.StoreWeb.Models.Bids;
using Factory.StoreWeb.ViewModels;
using Repository.Pattern.UnitOfWork;

namespace Factory.StoreWeb.Controllers
{
    public class BidController : Controller
    {
        private readonly IBidService _bidService;
        private readonly IShopperService _shopperService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public BidController(IBidService bidService, IShopperService shopperService, IUnitOfWorkAsync unitOfWorkAsync)
        {
            _bidService = bidService;
            _shopperService = shopperService;
            _unitOfWorkAsync = unitOfWorkAsync;
        }
        // GET: Bid
        public ViewResult Index()
        {
            var bids = _bidService.GetBids();
            var bidsDetails = Mapper.Map<IEnumerable<SerialBid>, IEnumerable<BidViewModel>>(bids);
            foreach (var bid in bidsDetails)
            {
                var shopper = _shopperService.GetShopperById(bid.ShopperId);
                bid.Shopper = shopper.Name;
            }
            return View(bidsDetails);
        }

        // GET: Bid/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bid/Create
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

        // GET: Bid/Edit/5
        public ActionResult Edit(int id)
        {
            var bid = _bidService.GetBidById(id);
            var editBid = Mapper.Map<SerialBid, BidFormModel>(bid);
            if (bid == null)
            {
                return HttpNotFound();
            }
            var shoppers = _shopperService.GetShoppers();
            editBid.Shoppers = shoppers.Select(s =>
                          new SelectListItem
                          {
                              Selected = (s.Id == bid.ShopperId),
                              Text = s.Name,
                              Value = s.Id.ToString()
                          });
            return View(editBid);
        }

        // POST: Bid/Edit/5
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

        // GET: Bid/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bid/Delete/5
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
