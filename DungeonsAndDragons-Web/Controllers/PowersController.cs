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
    public class PowersController : Controller
    {
        private DungeonsAndDragonsEntities db = new DungeonsAndDragonsEntities();

        // GET: Powers
        public ActionResult Index()
        {
            var powers = db.Powers.Include(p => p.Ability).Include(p => p.Ability1).Include(p => p.ActionType).Include(p => p.AttackType).Include(p => p.DamageType).Include(p => p.Defens).Include(p => p.DurationUnit).Include(p => p.EffectType).Include(p => p.PowerUsage).Include(p => p.Prerequisite);
            return View(powers.ToList());
        }

        // GET: Powers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Power power = db.Powers.Find(id);
            if (power == null)
            {
                return HttpNotFound();
            }
            return View(power);
        }

        // GET: Powers/Create
        public ActionResult Create()
        {
            ViewBag.AttackAbilityId = new SelectList(db.Abilities, "AbilityId", "Name");
            ViewBag.HitAbilityId = new SelectList(db.Abilities, "AbilityId", "Name");
            ViewBag.ActionTypeId = new SelectList(db.ActionTypes, "ActionTypeId", "Name");
            ViewBag.AttackTypeId = new SelectList(db.AttackTypes, "AttackTypeId", "Name");
            ViewBag.DamageTypeId = new SelectList(db.DamageTypes, "DamageTypeId", "Name");
            ViewBag.AttackDefenseId = new SelectList(db.Defenses, "DefenseId", "Name");
            ViewBag.DurationUnitId = new SelectList(db.DurationUnits, "DurationUnitId", "Name");
            ViewBag.EffectTypeId = new SelectList(db.EffectTypes, "EffectTypeId", "Name");
            ViewBag.PowerUsageId = new SelectList(db.PowerUsages, "PowerUsageId", "Name");
            ViewBag.PrerequisiteId = new SelectList(db.Prerequisites, "PrerequisiteId", "PrerequisiteId");
            return View();
        }

        // POST: Powers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PowerId,Name,TextDescription,PowerUsageId,EffectTypeId,ActionTypeId,AttackTypeId,PrerequisiteId,TargetType,MinNumTargets,MaxNumTargets,AttackAbilityId,AttackAbilityComplement,AttackDefenseId,AttackDefenseComplement,HitAbilityId,HitAbilityComplement,DamageTypeId,Duration,DurationUnitId,HasSecondaryAttack,IsConjuration,IsZone")] Power power)
        {
            if (ModelState.IsValid)
            {
                db.Powers.Add(power);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AttackAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", power.AttackAbilityId);
            ViewBag.HitAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", power.HitAbilityId);
            ViewBag.ActionTypeId = new SelectList(db.ActionTypes, "ActionTypeId", "Name", power.ActionTypeId);
            ViewBag.AttackTypeId = new SelectList(db.AttackTypes, "AttackTypeId", "Name", power.AttackTypeId);
            ViewBag.DamageTypeId = new SelectList(db.DamageTypes, "DamageTypeId", "Name", power.DamageTypeId);
            ViewBag.AttackDefenseId = new SelectList(db.Defenses, "DefenseId", "Name", power.AttackDefenseId);
            ViewBag.DurationUnitId = new SelectList(db.DurationUnits, "DurationUnitId", "Name", power.DurationUnitId);
            ViewBag.EffectTypeId = new SelectList(db.EffectTypes, "EffectTypeId", "Name", power.EffectTypeId);
            ViewBag.PowerUsageId = new SelectList(db.PowerUsages, "PowerUsageId", "Name", power.PowerUsageId);
            ViewBag.PrerequisiteId = new SelectList(db.Prerequisites, "PrerequisiteId", "PrerequisiteId", power.PrerequisiteId);
            return View(power);
        }

        // GET: Powers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Power power = db.Powers.Find(id);
            if (power == null)
            {
                return HttpNotFound();
            }
            ViewBag.AttackAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", power.AttackAbilityId);
            ViewBag.HitAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", power.HitAbilityId);
            ViewBag.ActionTypeId = new SelectList(db.ActionTypes, "ActionTypeId", "Name", power.ActionTypeId);
            ViewBag.AttackTypeId = new SelectList(db.AttackTypes, "AttackTypeId", "Name", power.AttackTypeId);
            ViewBag.DamageTypeId = new SelectList(db.DamageTypes, "DamageTypeId", "Name", power.DamageTypeId);
            ViewBag.AttackDefenseId = new SelectList(db.Defenses, "DefenseId", "Name", power.AttackDefenseId);
            ViewBag.DurationUnitId = new SelectList(db.DurationUnits, "DurationUnitId", "Name", power.DurationUnitId);
            ViewBag.EffectTypeId = new SelectList(db.EffectTypes, "EffectTypeId", "Name", power.EffectTypeId);
            ViewBag.PowerUsageId = new SelectList(db.PowerUsages, "PowerUsageId", "Name", power.PowerUsageId);
            ViewBag.PrerequisiteId = new SelectList(db.Prerequisites, "PrerequisiteId", "PrerequisiteId", power.PrerequisiteId);
            return View(power);
        }

        // POST: Powers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PowerId,Name,TextDescription,PowerUsageId,EffectTypeId,ActionTypeId,AttackTypeId,PrerequisiteId,TargetType,MinNumTargets,MaxNumTargets,AttackAbilityId,AttackAbilityComplement,AttackDefenseId,AttackDefenseComplement,HitAbilityId,HitAbilityComplement,DamageTypeId,Duration,DurationUnitId,HasSecondaryAttack,IsConjuration,IsZone")] Power power)
        {
            if (ModelState.IsValid)
            {
                db.Entry(power).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AttackAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", power.AttackAbilityId);
            ViewBag.HitAbilityId = new SelectList(db.Abilities, "AbilityId", "Name", power.HitAbilityId);
            ViewBag.ActionTypeId = new SelectList(db.ActionTypes, "ActionTypeId", "Name", power.ActionTypeId);
            ViewBag.AttackTypeId = new SelectList(db.AttackTypes, "AttackTypeId", "Name", power.AttackTypeId);
            ViewBag.DamageTypeId = new SelectList(db.DamageTypes, "DamageTypeId", "Name", power.DamageTypeId);
            ViewBag.AttackDefenseId = new SelectList(db.Defenses, "DefenseId", "Name", power.AttackDefenseId);
            ViewBag.DurationUnitId = new SelectList(db.DurationUnits, "DurationUnitId", "Name", power.DurationUnitId);
            ViewBag.EffectTypeId = new SelectList(db.EffectTypes, "EffectTypeId", "Name", power.EffectTypeId);
            ViewBag.PowerUsageId = new SelectList(db.PowerUsages, "PowerUsageId", "Name", power.PowerUsageId);
            ViewBag.PrerequisiteId = new SelectList(db.Prerequisites, "PrerequisiteId", "PrerequisiteId", power.PrerequisiteId);
            return View(power);
        }

        // GET: Powers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Power power = db.Powers.Find(id);
            if (power == null)
            {
                return HttpNotFound();
            }
            return View(power);
        }

        // POST: Powers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Power power = db.Powers.Find(id);
            db.Powers.Remove(power);
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
