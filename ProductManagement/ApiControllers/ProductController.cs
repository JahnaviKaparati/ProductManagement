using DataLayer;
using DataLayer.Services;
using DomainModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProductManagement.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductData data;
        private readonly ProdDbContext _db;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductController(IProductData _data, ProdDbContext db, IWebHostEnvironment hostEnvironment)
        {
            data = _data;
            _db = db;
            webHostEnvironment = hostEnvironment;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var model = data.GetAll();
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }
        [HttpGet("{id}")]
        [Route("GetById/{id}")]

        public IActionResult GetById(int id)
        {
            var singleData = _db.Products.FirstOrDefault(a => a.Id == id);
            if (singleData != null)
            {
                return Ok(singleData);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Create([FromForm] ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Product product = new Product
                {
                    Id = model.Id,
                    Name = model.Name,
                    Code = model.Code,
                    Available = model.Available,
                    Price = model.Price,
                    Rating = model.Rating,
                    Image = uniqueFileName,
                    Description = model.Description,
                };
                _db.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product");
        }
        private string UploadedFile([FromForm] ProductViewModel product)
        {
            string uniqueFileName = null;

            if (product.Image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + product.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    product.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromForm] Product product)//edit
        {
            var res = _db.Products.FirstOrDefault(e => e.Id == id);
            if (product == null)
            {
                return BadRequest($"Product with id {id.ToString()} not found");
            }
            else
            {
                res.Id = product.Id;
                res.Name = product.Name;
                res.Code = product.Code;
                res.Description = product.Description;
                res.Available = product.Available;
                res.Price = product.Price;
                _db.SaveChanges();
                return Ok(res);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid Character id");


            var s = _db.Products
                .Where(s => s.Id == id)
                .FirstOrDefault();

            _db.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}