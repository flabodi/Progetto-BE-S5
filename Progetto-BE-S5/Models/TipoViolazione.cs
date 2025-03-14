using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S5.Models
{
    public class TipoViolazione
    {
        [Key]
        public int IdViolazione { get; set; }
        public string Descrizione { get; set; }
    }
}
