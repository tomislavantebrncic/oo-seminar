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
    public class MedicalExaminationsController : Controller
    {
        private MedixEntities db = new MedixEntities();

        // GET: MedicalExaminations
        public ActionResult Index()
        {
            var medicalExaminations = db.MedicalExaminations.Include(m => m.Doctor).Include(m => m.ExaminationType).Include(m => m.WaitingRoom).Include(m => m.Patient);
            return View(medicalExaminations.ToList());
        }

        // GET: MedicalExaminations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalExamination medicalExamination = db.MedicalExaminations.Find(id);
            if (medicalExamination == null)
            {
                return HttpNotFound();
            }
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Create
        public ActionResult Create()
        {
            ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName");
            ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name");
            ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name");
            ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName");
            return View();
        }

        // POST: MedicalExaminations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ExaminationDate,Examined,Doctor_id,Patient_id,ExaminationType_id,WaitingRoom_id")] MedicalExamination medicalExamination)
        {
            if (ModelState.IsValid)
            {
                db.MedicalExaminations.Add(medicalExamination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName", medicalExamination.Doctor_id);
            ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name", medicalExamination.ExaminationType_id);
            ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name", medicalExamination.WaitingRoom_id);
            ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName", medicalExamination.Patient_id);
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalExamination medicalExamination = db.MedicalExaminations.Find(id);
            if (medicalExamination == null)
            {
                return HttpNotFound();
            }
            ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName", medicalExamination.Doctor_id);
            ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name", medicalExamination.ExaminationType_id);
            ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name", medicalExamination.WaitingRoom_id);
            ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName", medicalExamination.Patient_id);
            return View(medicalExamination);
        }

        // POST: MedicalExaminations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ExaminationDate,Examined,Doctor_id,Patient_id,ExaminationType_id,WaitingRoom_id")] MedicalExamination medicalExamination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalExamination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName", medicalExamination.Doctor_id);
            ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name", medicalExamination.ExaminationType_id);
            ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name", medicalExamination.WaitingRoom_id);
            ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName", medicalExamination.Patient_id);
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalExamination medicalExamination = db.MedicalExaminations.Find(id);
            if (medicalExamination == null)
            {
                return HttpNotFound();
            }
            return View(medicalExamination);
        }

        // POST: MedicalExaminations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicalExamination medicalExamination = db.MedicalExaminations.Find(id);
            db.MedicalExaminations.Remove(medicalExamination);
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
