using BackendAPI.Interfaces;
using BackendAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;

namespace AngularSampleProject2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        protected readonly IProductsService _productService;
        public HomeController(
            IProductsService productService
         )
        {
            _productService = productService;
        }

        [HttpGet(template: "GetProductsFirst", Name = "GetProductsFirst")]
        public async Task<IActionResult> GetProductsFirst()
        {
            try
            {
                var products = await _productService.GetProductsFirst();
                return Ok(products);
            } 
            catch
            {
                return Json(new { status = "error", message = "error returning ptoducts" });
            }
        }

        [HttpGet(template: "GetProductsSecond", Name = "GetProductsSecond")]
        public async Task<IActionResult> GetProductsSecond()
        {
            try
            {
                var products = await _productService.GetProductsSecond();
                return Ok(products);
            }
            catch
            {
                return Json(new { status = "error", message = "error returning ptoducts" });
            }
        }
    }
}
