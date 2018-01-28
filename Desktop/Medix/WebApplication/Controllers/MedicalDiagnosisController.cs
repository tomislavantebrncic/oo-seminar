using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Model;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MedicalDiagnosisController : Controller
    {
        private IDiagnosisService _service;

        public MedicalDiagnosisController(IDiagnosisService service)
        {
            _service = service;
        }

        // GET: MedicalDiagnosis
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        // GET: MedicalDiagnosis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalDiagnosis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameHRV,NameLAT")] MedicalDiagnosis medicalDiagnosis)
        {
            if (ModelState.IsValid)
            {
                _service.Add(medicalDiagnosis);
                return RedirectToAction("Index");
            }

            return View(medicalDiagnosis);
        }

    }
}
