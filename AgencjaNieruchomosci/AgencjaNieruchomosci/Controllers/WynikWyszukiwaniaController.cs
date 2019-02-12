using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencjaNieruchomosci.Controllers
{
    public class WynikWyszukiwaniaController : Controller
    {
        // GET: WynikWyszukiwania
        public ActionResult Index()
        {
            return View();
        }

        // GET: WynikWyszukiwania/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WynikWyszukiwania/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WynikWyszukiwania/Create
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

        // GET: WynikWyszukiwania/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WynikWyszukiwania/Edit/5
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

        // GET: WynikWyszukiwania/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WynikWyszukiwania/Delete/5
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
