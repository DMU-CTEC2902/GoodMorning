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
    public class MSCommentsController : Controller
    {
        private FilmContext db = new FilmContext();

        public ActionResult Index(int MovieStarId)
        {
            IEnumerable<MSComments> lstComments = db.comments.ToList();
            var result = lstComments.Where(s => s.MovieStarId == MovieStarId);
            
            // var reviews = db.Reviews.Select(k => k.FilmId == filmId).ToList();
            return View(result.ToList());
        }

        // GET: MSComments
        //public ActionResult Index()
        //{
        //    var comments = db.comments.Include(m => m.MovieStar).Include(m => m.User);
        //    return View(comments.ToList());
        //}

        // GET: MSComments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MSComments mSComments = db.comments.Find(id);
            if (mSComments == null)
            {
                return HttpNotFound();
            }
            return View(mSComments);
        }

        // GET: MSComments/Create
        public ActionResult Create(int MovieStarId)
        {
            ViewBag.MovieStarId = new SelectList(db.MovieStar, "MovieStarId", "Name",MovieStarId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName");
            return View();
        }

        // POST: MSComments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MSCommentsId,Title,Description,DateAdded,MovieStarId,UserId")] MSComments mSComments)
        {
            if (ModelState.IsValid)
            {
                db.comments.Add(mSComments);
                db.SaveChanges();
                return RedirectToAction("", new { MovieStarId = mSComments.MovieStarId});
            }

            ViewBag.MovieStarId = new SelectList(db.MovieStar, "MovieStarId", "Name", mSComments.MovieStarId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName", mSComments.UserId);
            return View(mSComments);
        }

        // GET: MSComments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MSComments mSComments = db.comments.Find(id);
            if (mSComments == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieStarId = new SelectList(db.MovieStar, "MovieStarId", "Name", mSComments.MovieStarId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName", mSComments.UserId);
            return View(mSComments);
        }

        // POST: MSComments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MSCommentsId,Title,Description,DateAdded,MovieStarId,UserId")] MSComments mSComments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mSComments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieStarId = new SelectList(db.MovieStar, "MovieStarId", "Name", mSComments.MovieStarId);
            ViewBag.UserId = new SelectList(db.user, "UserId", "UserName", mSComments.UserId);
            return View(mSComments);
        }

        // GET: MSComments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MSComments mSComments = db.comments.Find(id);
            if (mSComments == null)
            {
                return HttpNotFound();
            }
            return View(mSComments);
        }

        // POST: MSComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MSComments mSComments = db.comments.Find(id);
            db.comments.Remove(mSComments);
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
