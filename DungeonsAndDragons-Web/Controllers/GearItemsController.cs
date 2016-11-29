using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DungeonsAndDragons_Data;

namespace DungeonsAndDragons_Web.Controllers
{
    public class GearItemsController : Controller
    {
        private DungeonsAndDragonsEntities db = new DungeonsAndDragonsEntities();

        // GET: GearItems
        public ActionResult Index()
        {
            var gearItems = db.GearItems.Include(g => g.Actor).Include(g => g.ImplementType);
            return View(gearItems.ToList());
        }

        // GET: GearItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GearItem gearItem = db.GearItems.Find(id);
            if (gearItem == null)
            {
                return HttpNotFound();
            }
            return View(gearItem);
        }

        // GET: GearItems/Create
        public ActionResult Create()
        {
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId");
            ViewBag.ImplementTypeId = new SelectList(db.ImplementTypes, "ImplementTypeId", "Name");
            return View();
        }

        // POST: GearItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GearItemId,Name,Cost,WeightPounds,ImplementTypeId,OwnerActorId")] GearItem gearItem)
        {
            if (ModelState.IsValid)
            {
                db.GearItems.Add(gearItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", gearItem.OwnerActorId);
            ViewBag.ImplementTypeId = new SelectList(db.ImplementTypes, "ImplementTypeId", "Name", gearItem.ImplementTypeId);
            return View(gearItem);
        }

        // GET: GearItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GearItem gearItem = db.GearItems.Find(id);
            if (gearItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", gearItem.OwnerActorId);
            ViewBag.ImplementTypeId = new SelectList(db.ImplementTypes, "ImplementTypeId", "Name", gearItem.ImplementTypeId);
            return View(gearItem);
        }

        // POST: GearItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GearItemId,Name,Cost,WeightPounds,ImplementTypeId,OwnerActorId")] GearItem gearItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gearItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", gearItem.OwnerActorId);
            ViewBag.ImplementTypeId = new SelectList(db.ImplementTypes, "ImplementTypeId", "Name", gearItem.ImplementTypeId);
            return View(gearItem);
        }

        // GET: GearItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GearItem gearItem = db.GearItems.Find(id);
            if (gearItem == null)
            {
                return HttpNotFound();
            }
            return View(gearItem);
        }

        // POST: GearItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GearItem gearItem = db.GearItems.Find(id);
            db.GearItems.Remove(gearItem);
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
