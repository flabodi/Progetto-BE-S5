using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Progetto_BE_S5.Services;
using PoliziaApp.Services;

namespace PoliziaApp.Controllers
{
    public class VerbaleController : Controller
    {
        private readonly VerbaleServices _service;

        public VerbaleController(VerbaleServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Lista Verbali";

            // Carica i verbali con le entità associate Anagrafica e TipoViolazione
            var verbaliConAnagrafica = _service.GetAll()
                .Include(v => v.Anagrafica) // Include la proprietà di navigazione Anagrafica
                .Include(v => v.TipoViolazione); // Include la proprietà di navigazione TipoViolazione

            return View(verbaliConAnagrafica);
        }
    }
}
