using ECommerceProject.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Controllers
{
    public class iController : Controller
    {
        // GET: i
        ETicaretEntities context;

        public iController()
        {
            context = new ETicaretEntities();
        }

        public ActionResult Index()
        {
            
            return View();
        }
    }
}