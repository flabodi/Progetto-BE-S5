using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S5.Models
{
    public class Anagrafica
    {
        [Key]
        public int IdAnagrafica { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public string CAP { get; set; }
        public string CodFisc { get; set; }
    }
}
