﻿using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S5.Models
{
    public class Verbale
    {
        [Key]
        public int IdVerbale { get; set; }
        public int IdAnagrafica { get; set; }
        public int IdViolazione { get; set; }
        public DateTime DataViolazione { get; set; }
        public string Nominativo_Agente { get; set; }
        public DateTime DataTrascrizioneVerbale { get; set; }
        public decimal Importo { get; set; }
        public int DecurtamentoPunti { get; set; }

      
        public Anagrafica Anagrafica { get; set; }
        public TipoViolazione TipoViolazione { get; set; }
    }
}
