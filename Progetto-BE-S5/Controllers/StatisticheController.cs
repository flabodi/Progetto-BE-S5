using Microsoft.AspNetCore.Mvc;
using PoliziaApp.Services;
using Progetto_BE_S5.Services;

namespace PoliziaApp.Controllers
{
    public class StatisticheController : Controller
    {
        private readonly StatisticheServices _service;

        public StatisticheController(StatisticheServices service)
        {
            _service = service;
        }

        public IActionResult VerbaliPerTrasgressore()
        {
            ViewBag.Title = "Verbali per Trasgressore";
            return View(_service.GetVerbaliPerTrasgressore());
        }

        public IActionResult PuntiDecurtatiPerTrasgressore()
        {
            ViewBag.Title = "Punti Decurtati per Trasgressore";
            return View(_service.GetPuntiDecurtatiPerTrasgressore());
        }

        public IActionResult ViolazioniOltre10Punti()
        {
            ViewBag.Title = "Violazioni Oltre 10 Punti";
            return View(_service.GetViolazioniOltre10Punti());
        }

        public IActionResult ViolazioniOltre400Euro()
        {
            ViewBag.Title = "Violazioni Oltre 400 Euro";
            return View(_service.GetViolazioniOltre400Euro());
        }
    }
}
