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
        [HttpGet("bands/index")]
        public IActionResult Index()
        {
            var model = service.GetAllBands();
            return View(model);
        }


        //Action
        [HttpGet("Bands/details/{id}")]
        public IActionResult Detail(int id)
        {
            var modelLista = service.GetAllBands();
            var model = modelLista.FirstOrDefault(b => b.Id == id);
            return View(model);
        }
    }
}
