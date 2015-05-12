using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using JobShop.Models;

namespace JobShop.Controllers
{
    public class JobsController : Controller
    {
        private JobShopEntities db = new JobShopEntities();

        // GET: Jobs
        public ActionResult Index()
        {
            var jobs = db.Jobs.Include(j => j.AspNetUsers).Include(j => j.WorkPermit1).Include(j => j.WorkType1).Include(j => j.WorkIndustry1);
            return View(jobs.ToList());
        }

        // GET: Jobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return HttpNotFound();
            }
            return View(jobs);
        }

        // GET: Jobs/Create
        
        public ActionResult Create(Jobs jobs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewBag.User = new SelectList(db.AspNetUsers, "Id", "Email");
            
                    //Is Jobs has ID then we can understand that we have existing Jobs Information, so we need to perform Update Operation
                    //Perform Update
                    if (jobs.IdJob > 0)
                    {
                        var CurrentjobSkills = db.JobSkills.Where(p => p.Id_Job == jobs.IdJob);
                        foreach (JobSkills js in CurrentjobSkills)
                            db.JobSkills.Remove(js);
                        foreach (JobSkills js in jobs.JobSkills)
                            db.JobSkills.Add(js);

                        db.Entry(jobs).State = EntityState.Modified;
                    }
                    //Perform Save
                    else
                    {
                        db.Jobs.Add(jobs);
                        db.SaveChanges();
                        //return RedirectToAction("Index");
                        //iF Success== 1 then Save/Update Successfull else there it has to raise Exception
                        //return Json(new { Success = 1, IdJob = jobs.IdJob, ex = "" }, JsonRequestBehavior.AllowGet);
                    }
                    //db.SaveChanges();
                    ViewBag.User = new SelectList(db.AspNetUsers, "Id", "Email", jobs.User);
                    //iF Success== 1 then Save/Update Successfull else there it has to raise Exception
                    //return Json(new { Success = 1, IdJob = jobs.IdJob, ex = "" }, JsonRequestBehavior.AllowGet);
                    return View();
                }
            }
            catch (Exception ex)
            {
                //If Success== 0 then Unable to perform Save/Update Operation and send Exception to View as JSON
                return Json(new { Success = 0, ex = ex.Message.ToString() }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { Success = 0, ex = new Exception("Unable to save").Message.ToString() }, JsonRequestBehavior.AllowGet);
        }
        

         // GET: Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = "Edit";
            //Jobs jobs = db.Jobs.Find(id);

            ViewBag.User = new SelectList(db.AspNetUsers, "Id", "Email", jobs.User);
            ViewBag.WorkPermit = new SelectList(db.WorkPermit, "IdType", "WorkPermit1", jobs.WorkPermit);
            ViewBag.WorkType = new SelectList(db.WorkType, "IdType", "Type", jobs.WorkType);
            ViewBag.WorkIndustry = new SelectList(db.WorkIndustry, "IdIndustry", "Industry", jobs.WorkIndustry);
            return View("Create", jobs);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdJob,IdWho,User,DateAdd,VideoSRC,ImageSRC,MarkerImagePath,Titlu,WhereWhat,Description,Content,Solicitare,DateStart,DateEnd,Orar,Localitate,Address,Latitudine,Longitudine,ZIP,Region,Salary,MinSal,MaxSal,Active,WorkPermit,WorkType,WorkIndustry,Experience")] Jobs jobs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.User = new SelectList(db.AspNetUsers, "Id", "Email", jobs.User);
            ViewBag.WorkPermit = new SelectList(db.WorkPermit, "IdType", "WorkPermit1", jobs.WorkPermit);
            ViewBag.WorkType = new SelectList(db.WorkType, "IdType", "Type", jobs.WorkType);
            ViewBag.WorkIndustry = new SelectList(db.WorkIndustry, "IdIndustry", "Industry", jobs.WorkIndustry);
            return View(jobs);
        }

        // GET: Jobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return HttpNotFound();
            }
            return View(jobs);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jobs jobs = db.Jobs.Find(id);
            db.Jobs.Remove(jobs);
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
