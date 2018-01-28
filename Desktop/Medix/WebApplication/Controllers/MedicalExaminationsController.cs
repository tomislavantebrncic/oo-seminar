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
        private IMedicalExaminationService _exanimationService;
        private IPatientService _patientService;
        private IDoctorService _doctorService;
        private IExaminationTypeService _typeService;

        public MedicalExaminationsController(IMedicalExaminationService service, IDoctorService doctorService, IExaminationTypeService typeService, IPatientService patientService)
        {
            _exanimationService = service;
            _doctorService = doctorService;
            _typeService = typeService;
            _patientService = patientService;
        }

        // GET: MedicalExaminations
        public ActionResult Index(int doctor_id)
        {
            if (doctor_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var medicalExaminations = _exanimationService.GetAllByDoctorAndNonExamined(doctor_id);
            return View(medicalExaminations.ToList());
        }

        // GET: MedicalExaminations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var medicalExamination = _exanimationService.GetById(id.Value);
            if (medicalExamination == null)
            {
                return HttpNotFound();
            }
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Create
        public ActionResult Create(string employee_id)
        {
            ViewBag.ExaminationType = new SelectList(_typeService.GetAll());
            return View();
        }

        // POST: MedicalExaminations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MedicalExamination medicalExamination)
        {
            if (ModelState.IsValid)
            {
                if  (_patientService.GetByOIB(medicalExamination.Patient.OIB) == null)
                    ModelState.AddModelError("", "Neispravan OIB pacijenta.");
                _exanimationService.Add(medicalExamination);
                return RedirectToAction("Index");
            }
            return View(medicalExamination);
        }
    }
}
