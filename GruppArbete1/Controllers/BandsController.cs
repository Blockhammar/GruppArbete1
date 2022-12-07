using GruppArbete1.Models;
using Microsoft.AspNetCore.Mvc;

namespace GruppArbete1.Controllers
{
    public class BandsController : Controller
    {
        BandsService service;
        public BandsController()
        {
            service = new BandsService();

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
