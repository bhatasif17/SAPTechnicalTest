using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SAPTechnicalTest.Models;

namespace SAPTechnicalTest.Controllers
{
    [Authorize]
    public class UserRegistrationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserRegistrations
        public ActionResult Index()
        {
            var user = (from u in db.UserRegistrations
                        where u.Approval == "Approved"
                        select u);

            //var user = db.UserRegistrations.Where(t => t.Approval.Contains("Approved"));
            return View(user.ToList());
        }

        public ActionResult AdminIndex()
        {
            return View(db.UserRegistrations.ToList());
        }

        // GET: UserRegistrations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRegistration userRegistration = db.UserRegistrations.Find(id);
            if (userRegistration == null)
            {
                return HttpNotFound();
            }
            return View(userRegistration);
        }

        // GET: UserRegistrations/Create
        public ActionResult Create()
        {
            return View(new UserRegistration());
        }

        // POST: UserRegistrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Name,LoginID,UserGroup,Organisation,Department,Email,ContactNo,Status")] UserRegistration userRegistration)
        {
            if (ModelState.IsValid)
            {
                
                db.UserRegistrations.Add(userRegistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userRegistration);
        }

        // GET: UserRegistrations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRegistration userRegistration = db.UserRegistrations.Find(id);
            if (userRegistration == null)
            {
                return HttpNotFound();
            }
            return View(userRegistration);
        }

        // POST: UserRegistrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Name,LoginID,UserGroup,Organisation,Department,Email,ContactNo,Status,Approval")] UserRegistration userRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRegistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(userRegistration);
        }

        // GET: UserRegistrations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRegistration userRegistration = db.UserRegistrations.Find(id);
            if (userRegistration == null)
            {
                return HttpNotFound();
            }
            return View(userRegistration);
        }

        // POST: UserRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRegistration userRegistration = db.UserRegistrations.Find(id);
            db.UserRegistrations.Remove(userRegistration);
            db.SaveChanges();
            return RedirectToAction("Index");
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
