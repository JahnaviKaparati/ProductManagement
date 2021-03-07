using DataLayer;
using DataLayer.Services;
using DomainModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Data;
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
        public IActionResult Index()
        {
            var model = data.GetAll();
            if(model==null)
            {
                return NotFound();
            }
            return Ok(model);
        }
        [HttpPost]
        public IActionResult Create([FromForm] ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Product product = new Product
                {
                    Id=model.Id,
                    Name=model.Name,
                    Code=model.Code,
                    Available=model.Available,
                    Price=model.Price,
                    Rating=model.Rating,
                    Image=uniqueFileName,
                    Description=model.Description,
                };
                _db.Add(product);
                _db.SaveChanges();
                return Ok(product);
            }
            return Ok();
        }
        private string UploadedFile([FromForm]ProductViewModel product)
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
    }
}
