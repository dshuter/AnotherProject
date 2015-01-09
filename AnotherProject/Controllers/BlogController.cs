using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnotherProject.Models;

namespace AnotherProject.Controllers
{
    public class BlogController : Controller
    {
        private BlogModel blog = new BlogModel();
        //
        // GET: /Blog/

        public ActionResult Index(int? ID)
        {
            return View(blog);
        }

        public ActionResult Create(BlogModel blog)
        {

           
           
           
            
           
            return View();
        }

    }
}
