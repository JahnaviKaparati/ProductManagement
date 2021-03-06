using DataLayer;
using DataLayer.Services;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        IProductData pd;
        ProdDbContext db;
        public ProductController(IProductData _pd,ProdDbContext _db)
        {
            pd = _pd;
            db = _db;
        }
        public IActionResult Index()
        {
          
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
           

            return View();
        }
        
    }
}
