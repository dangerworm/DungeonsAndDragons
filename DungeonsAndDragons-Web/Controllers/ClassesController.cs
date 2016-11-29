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
    public class ClassesController : Controller
    {
        private DungeonsAndDragonsEntities db = new DungeonsAndDragonsEntities();

        // GET: Classes
        public ActionResult Index()
        {
            var classes = db.Classes.Include(c => c.Ability).Include(c => c.Ability1).Include(c => c.PowerSource).Include(c => c.Role);
            return View(classes.ToList());
        }

        // GET: Classes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class @class = db.Classes.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        // GET: Classes/Create
        public ActionResult Create()
        {
            ViewBag.BaseHitPointsAbilityId = new SelectList(db.Abilities, "AbilityId", "Name");
            ViewBag.HealingSurgesAbilityId = new SelectList(db.Abilities, "AbilityId", "Name");
            ViewBag.PowerSourceId = new SelectList(db.PowerSources, "PowerSourceId", "Name");
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "Name");
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClassId,Name,RoleId,PowerSourceId,BaseHitPoints,BaseHitPointsAbilityId,HitPointsPerLevel,HealingSurges,HealingSurgesAbilityId,FlavourText")] Class @class)
        {
            if (ModelState.IsValid)
            {
                db.Classes.Add(@class);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BaseHitPointsAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", @class.BaseHitPointsAbilityId);
            ViewBag.HealingSurgesAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", @class.HealingSurgesAbilityId);
            ViewBag.PowerSourceId = new SelectList(db.PowerSources, "PowerSourceId", "Name", @class.PowerSourceId);
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "Name", @class.RoleId);
            return View(@class);
        }

        // GET: Classes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class @class = db.Classes.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            ViewBag.BaseHitPointsAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", @class.BaseHitPointsAbilityId);
            ViewBag.HealingSurgesAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", @class.HealingSurgesAbilityId);
            ViewBag.PowerSourceId = new SelectList(db.PowerSources, "PowerSourceId", "Name", @class.PowerSourceId);
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "Name", @class.RoleId);
            return View(@class);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClassId,Name,RoleId,PowerSourceId,BaseHitPoints,BaseHitPointsAbilityId,HitPointsPerLevel,HealingSurges,HealingSurgesAbilityId,FlavourText")] Class @class)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@class).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BaseHitPointsAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", @class.BaseHitPointsAbilityId);
            ViewBag.HealingSurgesAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", @class.HealingSurgesAbilityId);
            ViewBag.PowerSourceId = new SelectList(db.PowerSources, "PowerSourceId", "Name", @class.PowerSourceId);
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "Name", @class.RoleId);
            return View(@class);
        }

        // GET: Classes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class @class = db.Classes.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Class @class = db.Classes.Find(id);
            db.Classes.Remove(@class);
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
