using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication.Controllers
{
    public class LoginController : Controller
    {
        private IDoctorService _doctorService;

        public LoginController(IDoctorService inDoctorService)
        {
            _doctorService = inDoctorService;
        }

        // GET: Login
        public ActionResult Index()
        {            
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var emp = _doctorService.GetDoctorWithIdAndPassword(employee.EmployeeID, employee.Password);
                if (emp != null)
                {
                    FormsAuthentication.SetAuthCookie(emp.EmployeeID, false);
                    return RedirectToAction("Index", "MedicalExaminations", new { doctor_id = emp.Id });
                }
                else
                {
                    ModelState.AddModelError("", "Neuspješna autorizacija.");
                }
            }
            return View(employee);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}