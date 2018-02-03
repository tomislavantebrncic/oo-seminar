﻿using BusinessLayer;
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
        private IDoctorService _doctorService;
        private IPatientService _patientService;

        public MedicalFindingsController(IMedicalFindingService findingService, IDiagnosisService diagnosisService, 
            IDoctorService doctorService, IPatientService patientService)
        {
            _diagnosisService = diagnosisService;
            _medicalfindingService = findingService;
            _doctorService = doctorService;
            _patientService = patientService;
        }

        // GET: MedicalFindings
        public ActionResult Index(string oib)
        {
            var lista = _medicalfindingService.findingsForPatient(_patientService.GetByOIB(oib));
            if (lista.Count == 0)
            {
                return Redirect(Request.UrlReferrer.ToString());
            }
            return View(lista);
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
        public ActionResult Create(string oib)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MedicalFinding medicalFinding)
        {
            medicalFinding.Doctor = _doctorService.GetByEmployeeId(User.Identity.Name);
            _medicalfindingService.Add(medicalFinding);
                return RedirectToAction("Index");
        }

    }
}
