using DataLayer;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    public class CustomerController : Controller
    {
        ProdDbContext db;
        
        public CustomerController(ProdDbContext _db)
        {
            db=_db;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public IActionResult Details(int id)
        {
            var prod = db.Products.Where(e => e.Id == id).FirstOrDefault();
            return View(prod);
        }
        public IActionResult List(string prodCode)
        {

            IEnumerable<Product> products;

            products = db.Products.Where(p => p.Code.Contains(prodCode)).OrderBy(p => p.Id);
            return View(products);
        }
    }
}
