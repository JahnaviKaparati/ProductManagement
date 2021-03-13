﻿using DataLayer;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        [HttpGet]
        public IActionResult Index(string prodSearch)
        {
            ViewData["GetProductDetails"] = prodSearch;
            var prodquery = from x in db.Products select x;
            if (!string.IsNullOrEmpty(prodSearch))
            {
                prodquery = prodquery.Where(x => x.Name.Contains(prodSearch));
            }
            return View(prodquery.AsNoTracking().ToList());
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

        public IActionResult ListOfProducts()
        {
            return View();
        }
    }
}
