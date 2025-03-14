using Microsoft.EntityFrameworkCore;
using Progetto_BE_S5.Models;
using Progetto_BE_S5.Data;

namespace PoliziaApp.Services
{
    public class VerbaleServices
    {
        private readonly ProgettoContext _context;

        public VerbaleServices(ProgettoContext context)
        {
            _context = context;
        }

        public IQueryable<Verbale> GetAll()
        {
            
            return _context.Verbali
                .Include(v => v.Anagrafica)
                .Include(v => v.TipoViolazione);
        }
    }
}
