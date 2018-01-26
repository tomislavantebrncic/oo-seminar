using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var employee = _doctorService.GetById(1);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}