using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ApplicationDbContext _context = new ApplicationDbContext();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.cmb_name = _context.Categorys.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(int categoryName)
        {
         
            return View();
        }
    }
}