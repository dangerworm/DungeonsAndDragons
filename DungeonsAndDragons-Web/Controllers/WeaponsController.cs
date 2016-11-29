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
    public class WeaponsController : Controller
    {
        private DungeonsAndDragonsEntities db = new DungeonsAndDragonsEntities();

        // GET: Weapons
        public ActionResult Index()
        {
            var weapons = db.Weapons.Include(w => w.Actor).Include(w => w.AttackClass).Include(w => w.WeaponCategory).Include(w => w.WeaponGroup);
            return View(weapons.ToList());
        }

        // GET: Weapons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weapon weapon = db.Weapons.Find(id);
            if (weapon == null)
            {
                return HttpNotFound();
            }
            return View(weapon);
        }

        // GET: Weapons/Create
        public ActionResult Create()
        {
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId");
            ViewBag.AttackClassId = new SelectList(db.AttackClasses, "AttackClassId", "AttackClassId");
            ViewBag.WeaponCategoryId = new SelectList(db.WeaponCategories, "WeaponCategoryId", "Name");
            ViewBag.WeaponGroupId = new SelectList(db.WeaponGroups, "WeaponGroupId", "Name");
            return View();
        }

        // POST: Weapons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeaponId,WeaponCategoryId,AttackClassId,Handedness,ProficiencyBonus,DamageNumDice,DamageDieSides,NormalRange,LongRange,Cost,WeightPounds,WeaponGroupId,OwnerActorId")] Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                db.Weapons.Add(weapon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", weapon.OwnerActorId);
            ViewBag.AttackClassId = new SelectList(db.AttackClasses, "AttackClassId", "AttackClassId", weapon.AttackClassId);
            ViewBag.WeaponCategoryId = new SelectList(db.WeaponCategories, "WeaponCategoryId", "Name", weapon.WeaponCategoryId);
            ViewBag.WeaponGroupId = new SelectList(db.WeaponGroups, "WeaponGroupId", "Name", weapon.WeaponGroupId);
            return View(weapon);
        }

        // GET: Weapons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weapon weapon = db.Weapons.Find(id);
            if (weapon == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", weapon.OwnerActorId);
            ViewBag.AttackClassId = new SelectList(db.AttackClasses, "AttackClassId", "AttackClassId", weapon.AttackClassId);
            ViewBag.WeaponCategoryId = new SelectList(db.WeaponCategories, "WeaponCategoryId", "Name", weapon.WeaponCategoryId);
            ViewBag.WeaponGroupId = new SelectList(db.WeaponGroups, "WeaponGroupId", "Name", weapon.WeaponGroupId);
            return View(weapon);
        }

        // POST: Weapons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeaponId,WeaponCategoryId,AttackClassId,Handedness,ProficiencyBonus,DamageNumDice,DamageDieSides,NormalRange,LongRange,Cost,WeightPounds,WeaponGroupId,OwnerActorId")] Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weapon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerActorId = new SelectList(db.Actors, "ActorId", "ActorId", weapon.OwnerActorId);
            ViewBag.AttackClassId = new SelectList(db.AttackClasses, "AttackClassId", "AttackClassId", weapon.AttackClassId);
            ViewBag.WeaponCategoryId = new SelectList(db.WeaponCategories, "WeaponCategoryId", "Name", weapon.WeaponCategoryId);
            ViewBag.WeaponGroupId = new SelectList(db.WeaponGroups, "WeaponGroupId", "Name", weapon.WeaponGroupId);
            return View(weapon);
        }

        // GET: Weapons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weapon weapon = db.Weapons.Find(id);
            if (weapon == null)
            {
                return HttpNotFound();
            }
            return View(weapon);
        }

        // POST: Weapons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Weapon weapon = db.Weapons.Find(id);
            db.Weapons.Remove(weapon);
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
