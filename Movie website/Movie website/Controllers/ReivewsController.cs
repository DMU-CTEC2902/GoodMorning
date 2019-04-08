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
        private FilmContext db = new FilmContext();

        public ActionResult FilmReviews(int filmId)
        {
            IEnumerable<Reivew> lstReviews = db.Reviews.ToList();
            var result = lstReviews.Where(s => s.FilmId == filmId);
            var total = lstReviews.Sum(s => s.Marks);
            var noOfItems = lstReviews.Count(); 
            if(noOfItems> 0)
            {
                ViewBag.AverageValue = total / noOfItems; 
            }
            else
            {
                ViewBag.AverageValue = 0; 
            }
            // var reviews = db.Reviews.Select(k => k.FilmId == filmId).ToList();
            return View(result.ToList());
        }
        // GET: Reivews
        public ActionResult Index()
        {
            var reviews = db.Reviews.Include(r => r.Film).Include(r => r.User);
            return View(reviews.ToList());
        }

        // GET: Reivews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reivew reivew = db.Reviews.Find(id);
            if (reivew == null)
            {
                return HttpNotFound();
            }
            return View(reivew);
        }

        // GET: Reivews/Create
        //public ActionResult Create()
        //{
        //    ViewBag.FilmId = new SelectList(db.Film, "FilmId", "FilmName");
        //    ViewBag.UserId = new SelectList(db.user, "UserId", "UserName");
        //    return View();
        //}
        public ActionResult Create(int filmId)
        {
            ViewBag.FilmId = new SelectList(db.Film, "FilmId", "FilmName",filmId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName");
            return View();
        }


        // POST: Reivews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReivewId,Title,Comments,DateAdded,Marks,FilmId,UserId")] Reivew reivew)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(reivew);
                db.SaveChanges();
                return RedirectToAction("FilmReviews", new { filmId = reivew.FilmId});
            }

            ViewBag.FilmId = new SelectList(db.Film, "FilmId", "FilmName", reivew.FilmId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName", reivew.UserId);
            return View(reivew);
        }

        // GET: Reivews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reivew reivew = db.Reviews.Find(id);
            if (reivew == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilmId = new SelectList(db.Film, "FilmId", "FilmName", reivew.FilmId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName", reivew.UserId);
            return View(reivew);
        }

        // POST: Reivews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReivewId,Title,Comments,DateAdded,Marks,FilmId,UserId")] Reivew reivew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reivew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FilmId = new SelectList(db.Film, "FilmId", "FilmName", reivew.FilmId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName", reivew.UserId);
            return View(reivew);
        }

        // GET: Reivews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reivew reivew = db.Reviews.Find(id);
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
            Reivew reivew = db.Reviews.Find(id);
            db.Reviews.Remove(reivew);
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
