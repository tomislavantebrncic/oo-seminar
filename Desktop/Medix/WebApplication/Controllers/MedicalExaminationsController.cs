using BusinessLayer;
using Model;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class MedicalExaminationsController : Controller
    {
        private IMedicalExaminationService service;
        private IPatientService _patientService;
        private IExaminationTypeService _typeService;

        // GET: MedicalExaminations
        public ActionResult Index(int doctor_id)
        {
            if (doctor_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var medicalExaminations = service.GetAllByDoctorAndNonExamined(doctor_id);
            return View(medicalExaminations.ToList());
        }

        // GET: MedicalExaminations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var medicalExamination = service.GetById(id.Value);
            if (medicalExamination == null)
            {
                return HttpNotFound();
            }
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Create
        public ActionResult Create(int doctor_id)
        {
            ViewBag.ExaminationType_id = new SelectList(_typeService.GetAll(), "Id", "Name");
            ViewBag.Patient_id = new SelectList(_patientService.GetAll(), "Id", "FirstName");
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
                service.Add(medicalExamination);
                return RedirectToAction("Index");
            }

            //ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName", medicalExamination.Doctor_id);
            //ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name", medicalExamination.ExaminationType_id);
            //ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name", medicalExamination.WaitingRoom_id);
            //ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName", medicalExamination.Patient_id);
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalExamination medicalExamination = service.GetById(id.Value);
            if (medicalExamination == null)
            {
                return HttpNotFound();
            }
            //ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName", medicalExamination.Doctor_id);
            //ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name", medicalExamination.ExaminationType_id);
            //ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name", medicalExamination.WaitingRoom_id);
            //ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName", medicalExamination.Patient_id);
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
                //db.Entry(medicalExamination).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.Doctor_id = new SelectList(db.Doctors, "Id", "FirstName", medicalExamination.Doctor_id);
            //ViewBag.ExaminationType_id = new SelectList(db.ExaminationTypes, "Id", "Name", medicalExamination.ExaminationType_id);
            //ViewBag.WaitingRoom_id = new SelectList(db.WaitingRooms, "Id", "Name", medicalExamination.WaitingRoom_id);
            //ViewBag.Patient_id = new SelectList(db.Patients, "Id", "FirstName", medicalExamination.Patient_id);
            return View(medicalExamination);
        }

        // POST: MedicalExaminations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //MedicalExamination medicalExamination = db.MedicalExaminations.Find(id);
            //db.MedicalExaminations.Remove(medicalExamination);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               // db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
