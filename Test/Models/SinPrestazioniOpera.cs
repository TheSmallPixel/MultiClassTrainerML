using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPrestazioniOpera
    {
        public int KeyPrestazioneOpera { get; set; }
        public int IdPrestazioneOpera { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdAnagrafica { get; set; }
        public string FlgTipoPrestatore { get; set; }
        public DateTime? DtPrestazione { get; set; }
        public decimal? Importo { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtInvioAnagrafeTributaria { get; set; }
    }
}
