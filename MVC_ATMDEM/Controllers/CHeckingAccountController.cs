using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MVC_ATMDEM.Models;

namespace MVC_ATMDEM.Controllers
{
    public class CHeckingAccountController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CHeckingAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CHeckingAccount/Details/5
        public ActionResult Details()
        {
            var userId = User.Identity.GetUserId();
            //var checkingAccount = new CheckingAccount
            //{
            //    AccountNumber = "0000123456",
            //    FirstName = "Sam",
            //    LastName = "pokhrel",
            //    Balance = 500
            //};

            var checkingAccount = db.CheckingAccounts.First(c => c.ApplicationUserId == userId);



            return View(checkingAccount);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult DetailsForAdmin(int id)
        {
            //var userId = User.Identity.GetUserId();
            var checkingAccount = db.CheckingAccounts.Find(id);
            return View("Details", checkingAccount);



            return View(checkingAccount);

        }

        public ActionResult List()
        {
            return View(db.CheckingAccounts.ToList());
        }

        // GET: CHeckingAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CHeckingAccount/Create
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

        // GET: CHeckingAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CHeckingAccount/Edit/5
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

        // GET: CHeckingAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CHeckingAccount/Delete/5
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
