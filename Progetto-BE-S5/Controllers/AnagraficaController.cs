using Microsoft.AspNetCore.Mvc;
using Progetto_BE_S5.Services;

namespace PoliziaApp.Controllers
{
    public class AnagraficaController : Controller
    {
        private readonly AnagraficaServices _service;

        public AnagraficaController(AnagraficaServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Gestione Trasgressori";
            return View(_service.GetAll());
        }

        public IActionResult Details(int id)
        {
            var anagrafica = _service.GetById(id);
            if (anagrafica == null)
            {
                return NotFound();
            }
            ViewBag.Message = "Dettagli Trasgressore";
            return View(anagrafica);
        }
    }
}
