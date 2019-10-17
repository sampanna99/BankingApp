using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ATMDEM.Models;

namespace MVC_ATMDEM.Controllers
{
    public class CHeckingAccountController : Controller
    {
        // GET: CHeckingAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CHeckingAccount/Details/5
        public ActionResult Details()
        {

            var checkingAccount = new CheckingAccount
            {
                AccountNumber = "0000123456",
                FirstName = "Sam",
                LastName = "pokhrel",
                Balance = 500
            };

            return View(checkingAccount);
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
