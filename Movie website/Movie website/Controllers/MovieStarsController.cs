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
    public class MovieStarsController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: MovieStars
        public ActionResult Index()
        {
            return View(db.MovieStar.ToList());
        }

        // GET: MovieStars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieStar movieStar = db.MovieStar.Find(id);
            if (movieStar == null)
            {
                return HttpNotFound();
            }
            return View(movieStar);
        }

        // GET: MovieStars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieStars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieStarId,Name,Image,IsActor,IsDirector")] MovieStar movieStar)
        {
            if (ModelState.IsValid)
            {
                db.MovieStar.Add(movieStar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieStar);
        }

        // GET: MovieStars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieStar movieStar = db.MovieStar.Find(id);
            if (movieStar == null)
            {
                return HttpNotFound();
            }
            return View(movieStar);
        }

        // POST: MovieStars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieStarId,Name,Image,IsActor,IsDirector")] MovieStar movieStar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieStar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieStar);
        }

        // GET: MovieStars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieStar movieStar = db.MovieStar.Find(id);
            if (movieStar == null)
            {
                return HttpNotFound();
            }
            return View(movieStar);
        }

        // POST: MovieStars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieStar movieStar = db.MovieStar.Find(id);
            db.MovieStar.Remove(movieStar);
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
