using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MedicalFindingsController : Controller
    {
        private MedixEntities db = new MedixEntities();

        // GET: MedicalFindings
        public ActionResult Index()
        {
            return View(db.MedicalFindings.ToList());
        }

        // GET: MedicalFindings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalFinding medicalFinding = db.MedicalFindings.Find(id);
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
                db.MedicalFindings.Add(medicalFinding);
                db.SaveChanges();
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
            MedicalFinding medicalFinding = db.MedicalFindings.Find(id);
            if (medicalFinding == null)
            {
                return HttpNotFound();
            }
            return View(medicalFinding);
        }

        // POST: MedicalFindings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date")] MedicalFinding medicalFinding)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalFinding).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicalFinding);
        }

        // GET: MedicalFindings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalFinding medicalFinding = db.MedicalFindings.Find(id);
            if (medicalFinding == null)
            {
                return HttpNotFound();
            }
            return View(medicalFinding);
        }

        // POST: MedicalFindings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicalFinding medicalFinding = db.MedicalFindings.Find(id);
            db.MedicalFindings.Remove(medicalFinding);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
