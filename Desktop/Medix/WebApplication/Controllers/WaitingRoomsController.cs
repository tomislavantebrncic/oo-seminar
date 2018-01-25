using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class WaitingRoomsController : Controller
    {
        private MedixEntities db = new MedixEntities();

        // GET: WaitingRooms
        public ActionResult Index()
        {
            return View(db.WaitingRooms.ToList());
        }

        // GET: WaitingRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitingRoom waitingRoom = db.WaitingRooms.Find(id);
            if (waitingRoom == null)
            {
                return HttpNotFound();
            }
            return View(waitingRoom);
        }

        // GET: WaitingRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaitingRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] WaitingRoom waitingRoom)
        {
            if (ModelState.IsValid)
            {
                db.WaitingRooms.Add(waitingRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(waitingRoom);
        }

        // GET: WaitingRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitingRoom waitingRoom = db.WaitingRooms.Find(id);
            if (waitingRoom == null)
            {
                return HttpNotFound();
            }
            return View(waitingRoom);
        }

        // POST: WaitingRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] WaitingRoom waitingRoom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(waitingRoom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(waitingRoom);
        }

        // GET: WaitingRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitingRoom waitingRoom = db.WaitingRooms.Find(id);
            if (waitingRoom == null)
            {
                return HttpNotFound();
            }
            return View(waitingRoom);
        }

        // POST: WaitingRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WaitingRoom waitingRoom = db.WaitingRooms.Find(id);
            db.WaitingRooms.Remove(waitingRoom);
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
