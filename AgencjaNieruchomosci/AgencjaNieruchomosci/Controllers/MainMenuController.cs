using AgencjaNieruchomosci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencjaNieruchomosci.Controllers
{
    public class MainMenuController : Controller
    {
        public String szukana;
        // GET: MainMenu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult cos(string szukane)
        {
            
            if (MainMenu.PrzeszukajBD(szukane) == null)
            {
                ViewBag.Wiadomosc = "Nie ma takiego elementu!";
                return View("~/Views/Shared/Blad.cshtml");
            }
            else
            {
                ViewBag.Wiadomosc = "Istnieje taki element! ";
                List<String> paczka = MainMenu.PrzeszukajBD(szukane);

                ViewBag.HLCN = paczka[0];
                ViewBag.HousePrice = "Cena: " + paczka[1];
                ViewBag.BathRooms = "Łazienki: " + paczka[2];
                ViewBag.BedRooms = "Sypialnie: " + paczka[3];
                ViewBag.HomeLocation = "Lokacja: " + paczka[4];
                ViewBag.ContactName = "Sprzedawca: " + paczka[5];
                ViewBag.Email = "Email: " + paczka[6];
                ViewBag.Phone = "Telefon: " + paczka[7];
                ViewBag.Addres = "Addres: " + paczka[8];
                ViewBag.SqFe = "Powierzchnia: " + paczka[9];
                ViewBag.YB = "Data budowy: " + paczka[10];
                ViewBag.LS = "Wielkość podwórka: " + paczka[11];
                ViewBag.Ga = "Garaż: " + paczka[12];
                ViewBag.Note = "Notatki: " + paczka[13];

                return View("~/Views/Shared/Sukces.cshtml");
            }
            
        }

        // GET: MainMenu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MainMenu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainMenu/Create
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

        // GET: MainMenu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainMenu/Edit/5
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

        // GET: MainMenu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MainMenu/Delete/5
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
