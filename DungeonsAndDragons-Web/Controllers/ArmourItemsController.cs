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
    public class ArmourItemsController : Controller
    {
        private DungeonsAndDragonsEntities db = new DungeonsAndDragonsEntities();

        // GET: ArmourItems
        public ActionResult Index()
        {
            var armourItems = db.ArmourItems.Include(a => a.Actor).Include(a => a.ArmourType);
            return View(armourItems.ToList());
        }

        // GET: ArmourItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArmourItem armourItem = db.ArmourItems.Find(id);
            if (armourItem == null)
            {
                return HttpNotFound();
            }
            return View(armourItem);
        }

        // GET: ArmourItems/Create
        public ActionResult Create()
        {
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId");
            ViewBag.ArmourTypeId = new SelectList(db.ArmourTypes, "ArmourTypeId", "Name");
            return View();
        }

        // POST: ArmourItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArmourItemId,ArmourTypeId,OwnerActorId,Name,IsMagic")] ArmourItem armourItem)
        {
            if (ModelState.IsValid)
            {
                db.ArmourItems.Add(armourItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", armourItem.OwnerActorId);
            ViewBag.ArmourTypeId = new SelectList(db.ArmourTypes, "ArmourTypeId", "Name", armourItem.ArmourTypeId);
            return View(armourItem);
        }

        // GET: ArmourItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArmourItem armourItem = db.ArmourItems.Find(id);
            if (armourItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", armourItem.OwnerActorId);
            ViewBag.ArmourTypeId = new SelectList(db.ArmourTypes, "ArmourTypeId", "Name", armourItem.ArmourTypeId);
            return View(armourItem);
        }

        // POST: ArmourItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArmourItemId,ArmourTypeId,OwnerActorId,Name,IsMagic")] ArmourItem armourItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(armourItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", armourItem.OwnerActorId);
            ViewBag.ArmourTypeId = new SelectList(db.ArmourTypes, "ArmourTypeId", "Name", armourItem.ArmourTypeId);
            return View(armourItem);
        }

        // GET: ArmourItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArmourItem armourItem = db.ArmourItems.Find(id);
            if (armourItem == null)
            {
                return HttpNotFound();
            }
            return View(armourItem);
        }

        // POST: ArmourItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArmourItem armourItem = db.ArmourItems.Find(id);
            db.ArmourItems.Remove(armourItem);
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
