﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        // GET: Insuree
        public ActionResult Index()
        {

            return View(db.Tables.ToList());
        }
        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create

        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            var name = table.DateOfBirth;
            var user = DateTime.Today.Year - name.Year;
            //a
            table.Quote = 50.0m;
            //b
            if (DateTime.Now.Year - table.DateOfBirth.Year <= 18)
            {
                table.Quote += 100m;
            }
            //c
            if (user >= 19 || user <= 25)
            {
                table.Quote += 50m;
            }
            //d
            if (DateTime.Now.Year - table.DateOfBirth.Year > 25)
            {
                table.Quote += 25m;
            }
            //e
            if (table.CarYear < 2000)
            {
                table.Quote += 25m;
            }
            //f
            if (table.CarYear > 2015)
            {
                table.Quote += 25m;
            }
            //g
            if (table.CarMake == "Porsche")
            {
                table.Quote += 25m;
            }
            //h
            if (table.CarMake == "Porsche" && table.CarModel == "911 Carrera")
            {
                table.Quote += 25m;
            }
            //i
            for (int i = 0; i < table.SpeedingTickets; i++)
            {
                table.Quote += 10m;
            }
            //j
            if (table.DUI == true)
            {
                table.Quote *= 1.25m;
            }
            //k
            if (table.CoverageType == true)
            {
                table.Quote *= 1.50m;
            }




            if (ModelState.IsValid)
            {
               
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

     

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
          
           if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
