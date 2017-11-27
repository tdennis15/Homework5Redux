using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework5.DAL;
using Homework5.Models;

namespace Homework5.Controllers
{

    /// <summary>
    /// Controller for the web form "DMV address update"
    /// </summary>
    public class HomeController : Controller
    {
        //Context for each user that would be added to the database
        private UserContext db = new UserContext();

        //First action is to load the index page when this program is run
        public ActionResult Index()
        {
            return View();
        }

        //Get: find User Details from input id
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);

        }

        //Get : returns Users create page so they can enter input
        public ActionResult Create()
        {
            return View();
        }

        //Post : Users create page submit so that the database gets updated after validation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "ID,FirstName,MiddleName,LastName,DOB,NAddress,NCity,NState,NZipCode,NCounty,CurrDate")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("DataList");
            }

            return View(user);
        }

        //Get: User edit see if the user the person is trying to edit is in the database.
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST : Users Edit if the data has been validated and the user is found
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,MiddleName,LastName,DOB,NAddress,NCity,NState,NZipCode,NCounty,CurrDate")]User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DataList");
            }
            return View(user);
        }


        // GET : Users Delete removing records if they exist
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users Delete removing from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("DataList");
        }

        public ActionResult DataList()
        {
            return View(db.Users.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}