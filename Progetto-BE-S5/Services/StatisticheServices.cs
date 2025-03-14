using Progetto_BE_S5.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Progetto_BE_S5.Data;

namespace PoliziaApp.Services
{
    public class StatisticheServices
    {
        private readonly ProgettoContext _context;

        public StatisticheServices(ProgettoContext context)
        {
            _context = context;
        }

     
        public object GetVerbaliPerTrasgressore() =>
            _context.Verbali
                .Include(v => v.Anagrafica)
                .GroupBy(v => new { v.IdAnagrafica, v.Anagrafica.Cognome, v.Anagrafica.Nome })
                .Select(g => new
                {
                    Trasgressore = g.Key.Cognome + " " + g.Key.Nome,
                    TotaleVerbali = g.Count()
                })
                .ToList();

        public object GetPuntiDecurtatiPerTrasgressore() =>
            _context.Verbali
                .Include(v => v.Anagrafica)
                .GroupBy(v => new { v.IdAnagrafica, v.Anagrafica.Cognome, v.Anagrafica.Nome })
                .Select(g => new
                {
                    Trasgressore = g.Key.Cognome + " " + g.Key.Nome,
                    TotalePunti = g.Sum(v => v.DecurtamentoPunti)
                })
                .ToList();

        public object GetViolazioniOltre10Punti() =>
            _context.Verbali
                .Include(v => v.Anagrafica)
                .Where(v => v.DecurtamentoPunti > 10)
                .Select(v => new
                {
                    v.Importo,
                    v.DataViolazione,
                    v.DecurtamentoPunti,
                    Anagrafica = new { v.Anagrafica.Cognome, v.Anagrafica.Nome }
                })
                .ToList();

      
        public object GetViolazioniOltre400Euro() =>
            _context.Verbali
                .Include(v => v.Anagrafica)
                .Where(v => v.Importo > 400)
                .Select(v => new
                {
                    v.Importo,
                    v.DataViolazione,
                    v.DecurtamentoPunti,
                    Anagrafica = new { v.Anagrafica.Cognome, v.Anagrafica.Nome }
                })
                .ToList();
    }
}
