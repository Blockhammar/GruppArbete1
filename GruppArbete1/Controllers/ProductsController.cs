using GruppArbete1.Models;
using Microsoft.AspNetCore.Mvc;

namespace GruppArbete1.Controllers
{
    public class ProductsController : Controller
    {
        ProductsService service;
        public ProductsController()
        {
            service = new ProductsService();

        }

        //Action
        [HttpGet("")]
        [HttpGet("index.php")]
        public IActionResult Index()
        {
            var model = service.GetAll();
            return View(model);
        }
    }
}
