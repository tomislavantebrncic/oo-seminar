using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class AddMedicalExaminationController : Controller
    {
        // GET: AddMedicalExamination
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Add(MedicalExamination medicalExamination)
        {

        }
    }
}