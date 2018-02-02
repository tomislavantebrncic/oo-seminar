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
    public class MedicalFindingsController : Controller
    {
        private IMedicalFindingService _medicalfindingService;
        private IDiagnosisService _diagnosisService;

        public MedicalFindingsController(IMedicalFindingService findingService, IDiagnosisService diagnosisService)
        {
            _diagnosisService = diagnosisService;
            _medicalfindingService = findingService;
        }

        // GET: MedicalFindings
        public ActionResult Index()
        {
            return View(_medicalfindingService.GetAll());
        }

        // GET: MedicalFindings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalFinding medicalFinding = _medicalfindingService.GetById(id.Value);
            if (medicalFinding == null)
            {
                return HttpNotFound();
            }
            return View(medicalFinding);
        }

        // GET: MedicalFindings/Create
        public ActionResult Create()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            lista.Add(new SelectListItem { Selected = true, Text = "Odaberi dijagnozu", Value = "-1" });

            foreach (var diagnosis in _diagnosisService.GetAll())
            {
                lista.Add(new SelectListItem {
                    Selected = false,
                    Text = diagnosis.NameHRV + " - " + diagnosis.NameLAT,
                    Value = diagnosis.Id.ToString()});
            }

            ViewBag.MedicalDiagnosis = new SelectList(lista, "Value", "Text");
            return View();
        }

        // POST: MedicalFindings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date")] MedicalFinding medicalFinding)
        {
            if (ModelState.IsValid)
            {
                _medicalfindingService.Add(medicalFinding);
                return RedirectToAction("Index");
            }

            return View(medicalFinding);
        }

        // GET: MedicalFindings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalFinding medicalFinding = _medicalfindingService.GetById(id.Value);
            if (medicalFinding == null)
            {
                return HttpNotFound();
            }
            return View(medicalFinding);
        }
    }
}
