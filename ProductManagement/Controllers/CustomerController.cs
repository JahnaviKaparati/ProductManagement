using DataLayer;
using DataLayer.Services;
using DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Uitility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService cs)
        {
            customerService = cs;
        }
        public IActionResult Index()
        {
            return View(customerService.ListOfProducts());
        }
        [HttpGet]
        public IActionResult Index(string prodSearch)
        {
            ViewData["GetProductDetails"] = prodSearch;
            var prodquery = customerService.Search(prodSearch);
            return View(prodquery);
        }
        [Authorize]

        public IActionResult Details(int id)
        {
            var prod = customerService.Details(id);
            return View(prod);
        }
        public IActionResult List(string prodCode)
        {
            var products = customerService.List(prodCode);
            return View(products);
        }

        public IActionResult ListOfProducts()
        {

            return View(customerService.ListOfProducts());
        }
    }
}