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

        public ActionResult Index(int? id)
        {
            IQueryable<DB.Products> products = context.Products;
            DB.Categories category = null;

            if (id.HasValue)
            {
                products = products.Where(x => x.Category_Id == id);
                category = context.Categories.FirstOrDefault(x => x.Id == id);

            }
            var viewModel = new Models.i.indexModel
            {
                Products = products.ToList(),
                Category =category
            };
            return View(viewModel);
        }
    }
}