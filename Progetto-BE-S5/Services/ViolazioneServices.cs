using Progetto_BE_S5.Data;
using Progetto_BE_S5.Models;
using static Progetto_BE_S5.Data.ProgettoContext;

namespace Progetto_BE_S5.Services
{
    public class ViolazioneServices
    {
        private readonly ProgettoContext _context;
        public ViolazioneServices(ProgettoContext context) { _context = context; }
        public List<TipoViolazione> GetAll() => _context.TipiViolazione.ToList();
    }
}
