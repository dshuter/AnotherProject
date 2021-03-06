﻿using AnotherProject.Models;
using System.Web.Mvc;


using AnotherProject.DAL;

namespace AnotherProject.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext db = new ProductContext();
        //
        // GET: /Products/

        public ActionResult Index(int? Products)
        {


            return View(db.Products);
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int? id)
        {
            return View();
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Products/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Products/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Products/Edit/5

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
        // GET: /Products/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Products/Delete/5

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
