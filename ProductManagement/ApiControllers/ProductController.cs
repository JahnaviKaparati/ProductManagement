using DataLayer.Services;
using DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public ProductController(IProductData _data)
        {
            data = _data;
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
            }
}
