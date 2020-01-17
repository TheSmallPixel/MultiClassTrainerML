using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistriParitari
    {
        public int KeyPolSinParitario { get; set; }
        public int? IdPolSinParitario { get; set; }
        public int? IdPolTestata { get; set; }
        public int? IdPolizza { get; set; }
        public DateTime? DtAccadimento { get; set; }
        public int? IdCompagnia { get; set; }
        public string NSinistro { get; set; }
        public int? AnnoPagamento { get; set; }
        public decimal? PercResponsabilita { get; set; }
        public string FlgMalusSino { get; set; }
        public string FlgPenalizzanteSino { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTipoDanno { get; set; }
        public int? AnnoSinistro { get; set; }
        public int? IdSinistro { get; set; }
    }
}
