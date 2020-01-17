using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiPortalePeriti
    {
        public int IdAllegatoPortalePeriti { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdIncarico { get; set; }
        public int? IdFiduciario { get; set; }
        public string CodPerito { get; set; }
        public string NomeFile { get; set; }
        public string TipologiaDocumento { get; set; }
        public DateTime? DtCaricamentoPortale { get; set; }
        public string NomeFileZip { get; set; }
        public string DtCaricamentoWise { get; set; }
    }
}
