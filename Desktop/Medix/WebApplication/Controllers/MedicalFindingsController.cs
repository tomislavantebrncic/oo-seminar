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

        public MedicalFindingsController(IMedicalFindingService findingService)
        {
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
