using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WissingCodeLouisvilleProject1.DAL;
using WissingCodeLouisvilleProject1.Models;

namespace WissingCodeLouisvilleProject1.Controllers
{
    public class InterviewController : Controller
    {
        private InterviewContext db = new InterviewContext();

        // GET: Interview
        public ActionResult Index(string searchString, string interviewerLastName, string intervieweeFirstName, string intervieweeLastName, string location, string eventName, string date, string duration, string notes)
        {
            var interviews = from m in db.Interviews
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                interviews = interviews.Where(s => s.InterviewerFirstName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(interviewerLastName))
            {
                interviews = interviews.Where(x => x.InterviewerLastName.Contains(interviewerLastName));
            }

            if (!String.IsNullOrEmpty(intervieweeFirstName))
            {
                interviews = interviews.Where(a => a.IntervieweeFirstName.Contains(intervieweeFirstName));
            }

            if (!String.IsNullOrEmpty(intervieweeLastName))
            {
                interviews = interviews.Where(b => b.IntervieweeLastName.Contains(intervieweeLastName));
            }

            if (!String.IsNullOrEmpty(location))
            {
                interviews = interviews.Where(c => c.Location.Contains(location));
            }

            if (!String.IsNullOrEmpty(eventName))
            {
                interviews = interviews.Where(d => d.EventName.Contains(eventName));
            }

            if (!String.IsNullOrEmpty(date))
            {
                interviews = interviews.Where(e => e.Date.Equals(date));
            }

            if (!String.IsNullOrEmpty(duration))
            {
                interviews = interviews.Where(g => g.Duration.Equals(duration));
            }

            if (!String.IsNullOrEmpty(notes))
            {
                interviews = interviews.Where(h => h.Notes.Contains(notes));
            }


            
            return View(interviews);
        }


        // GET: Interview/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interview interview = db.Interviews.Find(id);
            if (interview == null)
            {
                return HttpNotFound();
            }
            return View(interview);
        }

        // GET: Interview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interview/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InterviewID,InterviewerFirstName,InterviewerLastName,IntervieweeFirstName,IntervieweeLastName,Location,EventName,Date,Duration,Notes")] Interview interview)
        {
            if (ModelState.IsValid)
            {
                db.Interviews.Add(interview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interview);
        }

        // GET: Interview/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interview interview = db.Interviews.Find(id);
            if (interview == null)
            {
                return HttpNotFound();
            }
            return View(interview);
        }

        // POST: Interview/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InterviewID,InterviewerFirstName,InterviewerLastName,IntervieweeFirstName,IntervieweeLastName,Location,EventName,Date,Duration,Notes")] Interview interview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interview);
        }

        // GET: Interview/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Interview interview = db.Interviews.Find(id);
            if (interview == null)
            {
                return HttpNotFound();
            }
            return View(interview);
        }

        // POST: Interview/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Interview interview = db.Interviews.Find(id);
            db.Interviews.Remove(interview);
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
