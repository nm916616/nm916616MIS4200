using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nm916616MIS4200.Models;
using nm916616MIS4200.Models.DAL;

namespace nm916616MIS4200.Controllers
{
    public class OwnersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Owners
        public ActionResult Index()
        {
            var owners = db.Owners.Include(o => o.Pets).Include(o => o.Vets);
            return View(owners.ToList());
        }

        // GET: Owners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owners owners = db.Owners.Find(id);
            if (owners == null)
            {
                return HttpNotFound();
            }
            return View(owners);
        }

        // GET: Owners/Create
        public ActionResult Create()
        {
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName");
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "vetFirstName");
            return View();
        }

        // POST: Owners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ownerID,ownerFirstName,ownerLastName,phoneNumber,email,address,petID,vetID")] Owners owners)
        {
            if (ModelState.IsValid)
            {
                db.Owners.Add(owners);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", owners.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "vetFirstName", owners.vetID);
            return View(owners);
        }

        // GET: Owners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owners owners = db.Owners.Find(id);
            if (owners == null)
            {
                return HttpNotFound();
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", owners.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "vetFirstName", owners.vetID);
            return View(owners);
        }

        // POST: Owners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ownerID,ownerFirstName,ownerLastName,phoneNumber,email,address,petID,vetID")] Owners owners)
        {
            if (ModelState.IsValid)
            {
                db.Entry(owners).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "petName", owners.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "vetFirstName", owners.vetID);
            return View(owners);
        }

        // GET: Owners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owners owners = db.Owners.Find(id);
            if (owners == null)
            {
                return HttpNotFound();
            }
            return View(owners);
        }

        // POST: Owners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Owners owners = db.Owners.Find(id);
            db.Owners.Remove(owners);
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
