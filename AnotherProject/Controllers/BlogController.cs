using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnotherProject.Models;
using AnotherProject.DAL;

namespace AnotherProject.Controllers
{
    public class BlogController : Controller
    {
        private AnotherProject.DAL.BlogContext db = new BlogContext();
        //
        // GET: /Blog/

        public ActionResult Index(int? BlogModel)
        {
            return View(db.Blogs);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogModel blogmodel)
        {
            try
            {
                db.Blogs.Add(blogmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }


            
        }

      

    }
}
