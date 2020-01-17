using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDanniSpeseResistenza
    {
        public int KeyDannoSpesaResistenza { get; set; }
        public int IdDannoSpesaResistenza { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdDanno { get; set; }
        public DateTime? DtApertura { get; set; }
        public int? IdUtenteApertura { get; set; }
        public string FlgStato { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
