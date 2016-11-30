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
    public class PlayerCharactersController : Controller
    {
        private DungeonsAndDragonsEntities db = new DungeonsAndDragonsEntities();

        // GET: PlayerCharacters
        public ActionResult Index()
        {
            var playerCharacters = db.PlayerCharacters.Include(p => p.Actor).Include(p => p.Alignment).Include(p => p.Class).Include(p => p.Deity).Include(p => p.EpicDestiny).Include(p => p.Gender).Include(p => p.ParagonPath).Include(p => p.Race);
            return View(playerCharacters.ToList());
        }

        // GET: PlayerCharacters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerCharacter playerCharacter = db.PlayerCharacters.Find(id);
            if (playerCharacter == null)
            {
                return HttpNotFound();
            }
            return View(playerCharacter);
        }

        // GET: PlayerCharacters/Create
        public ActionResult Create()
        {
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorId");
            ViewBag.AlignmentId = new SelectList(db.Alignments, "AlignmentId", "AlignmentId");
            ViewBag.ClassId = new SelectList(db.Classes, "ClassId", "Name");
            ViewBag.DeityId = new SelectList(db.Deities, "DeityId", "Name");
            ViewBag.EpicDestinyId = new SelectList(db.EpicDestinies, "EpicDestinyId", "Name");
            ViewBag.GenderId = new SelectList(db.Genders, "GenderId", "Name");
            ViewBag.ParagonPathId = new SelectList(db.ParagonPaths, "ParagonPathId", "Name");
            ViewBag.RaceId = new SelectList(db.Races, "RaceId", "Name");
            return View();
        }

        // POST: PlayerCharacters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,CombatLevel,ClassId,ParagonPathId,EpicDestinyId,ExperiencePoints,RaceId,Age,GenderId,Height,WeightPounds,AlignmentId,DeityId,Initiative,PassiveInsight,PassivePerception,HitPoints,BaseActionPoints,AdditionalActionPoints,Picture")] PlayerCharacter playerCharacter)
        {
            var actor = new Actor
            {
                ActorTypeId = 1,
            };
            db.Actors.Add(actor);
            db.SaveChanges();

            playerCharacter.ActorId = actor.ActorId;
            if (ModelState.IsValid)
            {
                db.PlayerCharacters.Add(playerCharacter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorId", playerCharacter.ActorId);
            ViewBag.AlignmentId = new SelectList(db.Alignments, "AlignmentId", "AlignmentId", playerCharacter.AlignmentId);
            ViewBag.ClassId = new SelectList(db.Classes, "ClassId", "Name", playerCharacter.ClassId);
            ViewBag.DeityId = new SelectList(db.Deities, "DeityId", "Name", playerCharacter.DeityId);
            ViewBag.EpicDestinyId = new SelectList(db.EpicDestinies, "EpicDestinyId", "Name", playerCharacter.EpicDestinyId);
            ViewBag.GenderId = new SelectList(db.Genders, "GenderId", "Name", playerCharacter.GenderId);
            ViewBag.ParagonPathId = new SelectList(db.ParagonPaths, "ParagonPathId", "Name", playerCharacter.ParagonPathId);
            ViewBag.RaceId = new SelectList(db.Races, "RaceId", "Name", playerCharacter.RaceId);
            return View(playerCharacter);
        }

        // GET: PlayerCharacters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerCharacter playerCharacter = db.PlayerCharacters.Find(id);
            if (playerCharacter == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorId", playerCharacter.ActorId);
            ViewBag.AlignmentId = new SelectList(db.Alignments, "AlignmentId", "AlignmentId", playerCharacter.AlignmentId);
            ViewBag.ClassId = new SelectList(db.Classes, "ClassId", "Name", playerCharacter.ClassId);
            ViewBag.DeityId = new SelectList(db.Deities, "DeityId", "Name", playerCharacter.DeityId);
            ViewBag.EpicDestinyId = new SelectList(db.EpicDestinies, "EpicDestinyId", "Name", playerCharacter.EpicDestinyId);
            ViewBag.GenderId = new SelectList(db.Genders, "GenderId", "Name", playerCharacter.GenderId);
            ViewBag.ParagonPathId = new SelectList(db.ParagonPaths, "ParagonPathId", "Name", playerCharacter.ParagonPathId);
            ViewBag.RaceId = new SelectList(db.Races, "RaceId", "Name", playerCharacter.RaceId);
            return View(playerCharacter);
        }

        // POST: PlayerCharacters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerCharacterId,ActorId,ActorTypeId,Name,CombatLevel,ClassId,ParagonPathId,EpicDestinyId,ExperiencePoints,RaceId,Age,GenderId,Height,WeightPounds,AlignmentId,DeityId,Initiative,PassiveInsight,PassivePerception,HitPoints,BaseActionPoints,AdditionalActionPoints,Picture")] PlayerCharacter playerCharacter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerCharacter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorId", playerCharacter.ActorId);
            ViewBag.AlignmentId = new SelectList(db.Alignments, "AlignmentId", "AlignmentId", playerCharacter.AlignmentId);
            ViewBag.ClassId = new SelectList(db.Classes, "ClassId", "Name", playerCharacter.ClassId);
            ViewBag.DeityId = new SelectList(db.Deities, "DeityId", "Name", playerCharacter.DeityId);
            ViewBag.EpicDestinyId = new SelectList(db.EpicDestinies, "EpicDestinyId", "Name", playerCharacter.EpicDestinyId);
            ViewBag.GenderId = new SelectList(db.Genders, "GenderId", "Name", playerCharacter.GenderId);
            ViewBag.ParagonPathId = new SelectList(db.ParagonPaths, "ParagonPathId", "Name", playerCharacter.ParagonPathId);
            ViewBag.RaceId = new SelectList(db.Races, "RaceId", "Name", playerCharacter.RaceId);
            return View(playerCharacter);
        }

        // GET: PlayerCharacters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerCharacter playerCharacter = db.PlayerCharacters.Find(id);
            if (playerCharacter == null)
            {
                return HttpNotFound();
            }
            return View(playerCharacter);
        }

        // POST: PlayerCharacters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerCharacter playerCharacter = db.PlayerCharacters.Find(id);
            db.PlayerCharacters.Remove(playerCharacter);
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
