using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencjaNieruchomosci.Controllers
{
    public class DomController : Controller
    {
        // GET: Dom
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dom/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dom/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dom/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dom/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dom/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dom/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
