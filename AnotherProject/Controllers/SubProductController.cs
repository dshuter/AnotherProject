using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnotherProject.DAL;

namespace AnotherProject.Controllers
{
    public class SubProductController : Controller
    {
        private ProductContext db = new ProductContext();
        //
        // GET: /SubProduct/

        public ActionResult Index(int? SubProducts)
        {
            return View(db.Subproducts);
        }

        //
        // GET: /SubProduct/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SubProduct/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SubProduct/Create

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

        //
        // GET: /SubProduct/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SubProduct/Edit/5

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

        //
        // GET: /SubProduct/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SubProduct/Delete/5

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
