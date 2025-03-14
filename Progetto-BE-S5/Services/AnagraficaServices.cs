using Progetto_BE_S5.Data;
using Progetto_BE_S5.Models;

public class AnagraficaServices
{
    private readonly ProgettoContext _context;

    public AnagraficaServices(ProgettoContext context)
    {
        _context = context;
    }

    public List<Anagrafica> GetAll() => _context.Anagrafiche.ToList();
    public Anagrafica GetById(int id) => _context.Anagrafiche.Find(id);
    public void Create(Anagrafica anagrafica)
    {
        _context.Anagrafiche.Add(anagrafica);
        _context.SaveChanges();
    }
}
