using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionDeCV.Models;

namespace GestionDeCV.Controllers
{
    public class CandidateGeneralnfoesController : Controller
    {
        private CandidateDBContext db = new CandidateDBContext();

        // GET: CandidateGeneralnfoes
        public ActionResult Index()
        {
            return View(db.dboCandidateGeneralnfo.ToList());
        }

        // GET: CandidateGeneralnfoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidateGeneralnfo candidateGeneralnfo = db.dboCandidateGeneralnfo.Find(id);
            if (candidateGeneralnfo == null)
            {
                return HttpNotFound();
            }
            return View(candidateGeneralnfo);
        }

        // GET: CandidateGeneralnfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidateGeneralnfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,SecondName,LastName,DocumentId,DateOfBirth,CountryOfBirth,CityOfBirth,PhoneNumber,CellPhoneNumner,Address1,Address2,AddressCity,AddressDepartment,email")] CandidateGeneralnfo candidateGeneralnfo)
        {
            if (ModelState.IsValid)
            {
                candidateGeneralnfo.Id = Guid.NewGuid();
                db.dboCandidateGeneralnfo.Add(candidateGeneralnfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidateGeneralnfo);
        }

        // GET: CandidateGeneralnfoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidateGeneralnfo candidateGeneralnfo = db.dboCandidateGeneralnfo.Find(id);
            if (candidateGeneralnfo == null)
            {
                return HttpNotFound();
            }
            return View(candidateGeneralnfo);
        }

        // POST: CandidateGeneralnfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,SecondName,LastName,DocumentId,DateOfBirth,CountryOfBirth,CityOfBirth,PhoneNumber,CellPhoneNumner,Address1,Address2,AddressCity,AddressDepartment,email")] CandidateGeneralnfo candidateGeneralnfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidateGeneralnfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidateGeneralnfo);
        }

        // GET: CandidateGeneralnfoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidateGeneralnfo candidateGeneralnfo = db.dboCandidateGeneralnfo.Find(id);
            if (candidateGeneralnfo == null)
            {
                return HttpNotFound();
            }
            return View(candidateGeneralnfo);
        }

        // POST: CandidateGeneralnfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CandidateGeneralnfo candidateGeneralnfo = db.dboCandidateGeneralnfo.Find(id);
            db.dboCandidateGeneralnfo.Remove(candidateGeneralnfo);
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
