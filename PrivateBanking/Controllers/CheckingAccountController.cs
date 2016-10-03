using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PrivateBanking.Models;


namespace PrivateBanking.Controllers
{
    public class CheckingAccountController : Controller
    {
        // get dbcontext object to work with database
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CheckingAccount
        public ActionResult Index()
        {
            return View();
        }



        // right click action to add a view
        // chose detail as template
        // chose CheckingAccount as model class
        // only check use a layout page
        public ActionResult Details()
        {
            string currentUserId = User.Identity.GetUserId();
            var checkingAccount = db.CheckingAccounts.First(c => c.ApplicationUserId == currentUserId);
            return View(checkingAccount);
        }

        // GET: CheckingAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckingAccount/Create
        // add view by choosing create template, ChekcingAccount model and chekc reference script libaries and use layout page
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

        // GET: CheckingAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Edit/5
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

        // GET: CheckingAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Delete/5
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
