﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FutboleAR.Models;

namespace FutboleAR.Controllers
{
    public class MatchModelsController : Controller
    {
        private FutbolearDBContext db = new FutbolearDBContext();

        // GET: MatchModels
        public ActionResult Index()
        {
            return View(db.Matches.ToList());
        }

        // POST: MatchModels
        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult JoinMatch([Bind(Include = "ID")] MatchModels matchModels)
        {
            return View("JoinMatch");
        }

        // GET: MatchModels
        public ActionResult MyMatches()
        {
            return View(db.Matches.ToList());
        }

        // GET: MatchModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchModels matchModels = db.Matches.Find(id);
            if (matchModels == null)
            {
                return HttpNotFound();
            }
            return View(matchModels);
        }

        // GET: MatchModels/Create
        public ActionResult Create()
        {


            var items = db.Canchas.ToList();

            if (items != null)
            {
                ViewBag.data = items;
            }


            return View();
        }

        // POST: MatchModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FechaHora")] MatchModels matchModels)
        {
            if (ModelState.IsValid)
            {
                db.Matches.Add(matchModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(matchModels);
        }

        // GET: MatchModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchModels matchModels = db.Matches.Find(id);
            if (matchModels == null)
            {
                return HttpNotFound();
            }
            return View(matchModels);
        }

        // POST: MatchModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FechaHora")] MatchModels matchModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matchModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matchModels);
        }

        // GET: MatchModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchModels matchModels = db.Matches.Find(id);
            if (matchModels == null)
            {
                return HttpNotFound();
            }
            return View(matchModels);
        }

        // POST: MatchModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MatchModels matchModels = db.Matches.Find(id);
            db.Matches.Remove(matchModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MatchModels/JoinMatch
        public ActionResult JoinMatch(int? id)
        {
            UserModels userModels = db.Users.Find(id);

            return View(userModels);
        }

        [HttpPost, ActionName("JoinMatch")]
        [ValidateAntiForgeryToken]
        public ActionResult JoinMatch([Bind(Include = "ID,Nombre,Apellido,Mail")] UserModels userModels)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(userModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userModels);
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
