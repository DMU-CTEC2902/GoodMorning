using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Movie_website.Models;

namespace Movie_website.Controllers
{
    public class ReivewsController : Controller
    {
        private ReivewContext db = new ReivewContext();

        // GET: Reivews
        public ActionResult Index()
        {
            //var reivews = db.Reivews.Include(r => r.User);
            //return View(reivews.ToList());
            return View(db.Reivews.ToList());
        }

        // GET: Reivews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reivew reivew = db.Reivews.Find(id);
            if (reivew == null)
            {
                return HttpNotFound();
            }
            return View(reivew);
        }

        // GET: Reivews/Create
        public ActionResult Create()
        {
            //ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName");
            return View();
        }

        // POST: Reivews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReivewId,Title,Comments,DateAdded,Marks")] Reivew reivew)
        {
            if (ModelState.IsValid)
            {
                db.Reivews.Add(reivew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", reivew.UserId);
            return View(reivew);
        }

        // GET: Reivews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reivew reivew = db.Reivews.Find(id);
            if (reivew == null)
            {
                return HttpNotFound();
            }
            //ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", reivew.UserId);
            return View(reivew);
        }

        // POST: Reivews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReivewId,Title,Comments,DateAdded,Marks")] Reivew reivew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reivew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", reivew.UserId);
            return View(reivew);
        }

        // GET: Reivews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reivew reivew = db.Reivews.Find(id);
            if (reivew == null)
            {
                return HttpNotFound();
            }
            return View(reivew);
        }

        // POST: Reivews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reivew reivew = db.Reivews.Find(id);
            db.Reivews.Remove(reivew);
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
