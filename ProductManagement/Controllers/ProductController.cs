using DataLayer;
using DataLayer.Services;
using DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IProductData _ipd;
        string apiurl;
        ProdDbContext _db;
        public ProductController(ILogger<ProductController> logger, IConfiguration configuration, ProdDbContext db, IProductData ipd)
        {
            _logger = logger;
            _configuration = configuration;
            apiurl = _configuration.GetValue<string>("WebAPIBaseUrl");
            _db = db;
            _ipd = ipd;
        }
        public async Task<IActionResult> Index()
        {
            var prod = new List<Product>();
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44356/api/product"))
                /* using (var response = await client.GetAsync(apiurl))*/
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    prod = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(prod);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string ProdSearch)
        {
            ViewData["GetProductDetails"] = ProdSearch;
            var prodquery = from x in _db.Products select x;
            if (!string.IsNullOrEmpty(ProdSearch))
            {
                prodquery = prodquery.Where(x => x.Name.Contains(ProdSearch));
            }
            return View(await prodquery.AsNoTracking().ToListAsync());
        }
        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var prod = new Product();
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF32, "application/json");
                using (var response = await client.PostAsync(apiurl, content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    prod = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return RedirectToAction("Index", "Product");
            //return View(rescharacter);
        }
        //[HttpDelete]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44356/api/product");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Product/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }

        }
        public async Task<IActionResult> Edit(int id)
        {
            var prodData = new Product();

            using (HttpClient client = new HttpClient())
            {
                //client.BaseAddress = new Uri("https://localhost:44356/api/product");
                using (var response = await client.GetAsync($"{apiurl}/{id}"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    prodData = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(prodData);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(int id, Product product)
        {
            var prodData = new Product();
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8,
                    "application/json");
                using (var response = await client.PutAsync($"{apiurl}/{id}", content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    prodData = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            var prod = new Product();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{apiurl}/{id}"))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        prod = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                    else
                    {

                        ViewBag.StatusCode = response.StatusCode;
                    }
                }
            }
            return View(prod);



        }

        public IActionResult List(string prodCode)
        {

            IEnumerable<Product> products;

            products = _db.Products.Where(p => p.Code.Contains(prodCode)).OrderBy(p => p.Id);
            return View(products);
        }
    }    
}
