﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RetialBusinessApp.Models;
using System.Collections.Generic;
using System;

namespace RetialBusinessApp.Controllers
{
    public class RetailController : Controller
    {
        // GET: Retail
        public ActionResult Index()
        {
            return View();
        }

        // GET: Retail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Retail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Retail/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Retail/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new RetailModel
            {
                OperatedSince = "TwoToFiveYears",
                FranchiseAreas = new List<SelectListItem>
                {
                    new SelectListItem { Text= "Gachibowli", Value = "Gachibowli" },
                    new SelectListItem { Text= "Chanda Nagar", Value = "ChandaNagar" },
                    new SelectListItem { Text= "LB Nagar", Value = "LBNagar" },
                    new SelectListItem { Text= "Kukatpally", Value = "Kukatpally" }

                },
            };
            return View(model);
        }

        // POST: Retail/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                WriteToExcel.WriteData(collection);

                if (ModelState.IsValid)
                {
                    // TODO: Add update logic here
                    return RedirectToAction(nameof(Index));
                }
                else { return View(); }
                    
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Retail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Retail/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}