using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
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
        private IStatisticsService _statisticService;

        public MedicalExaminationsController(IMedicalExaminationService service, IDoctorService doctorService,
            IExaminationTypeService typeService, IPatientService patientService, IStatisticsService statistics)
        {
            _exanimationService = service;
            _doctorService = doctorService;
            _typeService = typeService;
            _patientService = patientService;
            _statisticService = statistics;
        }

        // GET: MedicalExaminations
        public ActionResult Index()
        {
            var medicalExaminations = _exanimationService.GetAllByDoctorAndNonExamined(_doctorService.GetByEmployeeId(User.Identity.Name).Id);
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
            List<SelectListItem> lista = new List<SelectListItem>();
            lista.Add(new SelectListItem { Selected = true, Text = "Odaberi", Value = "-1" });

            foreach (var examination in _typeService.GetAll())
            {
                lista.Add(new SelectListItem
                {
                    Selected = false,
                    Text = examination.Name,
                    Value = examination.Id.ToString()
                });
            }
            ViewBag.ExaminationType = new SelectList(lista, "Value", "Text");
            return View();
        }

        // POST: MedicalExaminations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MedicalExamination medicalExamination)
        {
            ViewBag.ExanimationType = new SelectList(_typeService.GetAll(), "Value", "Text");
            ViewData["ExanimationType"] = new SelectList(_typeService.GetAll(), "Value", "Text");

            medicalExamination.Doctor = _doctorService.GetByEmployeeId(User.Identity.Name);
            medicalExamination.WaitingRoom = medicalExamination.Doctor.WaitingRoom;
            if (_patientService.GetByOIB(medicalExamination.Patient.OIB) == null)
            {
                ModelState.AddModelError("", "Neispravan OIB pacijenta.");
                //pokazi gresku
            }
            else
            {
                medicalExamination.Patient = _patientService.GetByOIB(medicalExamination.Patient.OIB);
                _exanimationService.Add(medicalExamination);

            }
                
                return RedirectToAction("Index");

            // return View(medicalExamination);
        }

        public ActionResult Statistics()
        {
            var statistics = _statisticService.CalculateStatistics(
                DateTime.Today, _doctorService.GetByEmployeeId(User.Identity.Name));
            return View(statistics);
        }
    }
}
