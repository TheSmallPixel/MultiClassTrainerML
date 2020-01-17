using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiRichiesteDati
    {
        public decimal IdRichiesta { get; set; }
        public decimal IdSinistro { get; set; }
        public DateTime? DtCreazioneFile { get; set; }
        public decimal? IdAnagraficaDestinatario { get; set; }
        public decimal? IdCsl { get; set; }
        public decimal? IdEntitacoinvolta1 { get; set; }
        public decimal? IdEntitacoinvolta2 { get; set; }
        public string RuoloDestinatario { get; set; }
    }
}
