using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TheatrecrudsController : Controller
    {
        private BMSEntities db = new BMSEntities();

        // GET: Theatrecruds
        public ActionResult Home()
        {
            return View(db.Theatrecruds.ToList());
        }
        public ActionResult Admin()
        {
            return View(db.Theatrecruds.ToList());
        }

        // GET: Theatrecruds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Theatrecrud theatrecrud = db.Theatrecruds.Find(id);
            if (theatrecrud == null)
            {
                return HttpNotFound();
            }
            return View(theatrecrud);
        }

        // GET: Theatrecruds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Theatrecruds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TheatreId,TheatreName,Location")] Theatrecrud theatrecrud)
        {
            if (ModelState.IsValid)
            {
                db.Theatrecruds.Add(theatrecrud);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(theatrecrud);
        }

        // GET: Theatrecruds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Theatrecrud theatrecrud = db.Theatrecruds.Find(id);
            if (theatrecrud == null)
            {
                return HttpNotFound();
            }
            return View(theatrecrud);
        }

        // POST: Theatrecruds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TheatreId,TheatreName,Location")] Theatrecrud theatrecrud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theatrecrud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(theatrecrud);
        }

        // GET: Theatrecruds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Theatrecrud theatrecrud = db.Theatrecruds.Find(id);
            if (theatrecrud == null)
            {
                return HttpNotFound();
            }
            return View(theatrecrud);
        }

        // POST: Theatrecruds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Theatrecrud theatrecrud = db.Theatrecruds.Find(id);
            db.Theatrecruds.Remove(theatrecrud);
            db.SaveChanges();
            return RedirectToAction("Admin");
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
