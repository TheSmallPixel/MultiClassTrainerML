using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaDiario
    {
        public decimal KeyEntitaDiario { get; set; }
        public decimal IdEntitaDiario { get; set; }
        public DateTime DtNota { get; set; }
        public string Note { get; set; }
        public decimal? IdEntitacoinvolta { get; set; }
        public int? IdSinistro { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdOggetto { get; set; }
        public string FlgEvidenzaSollecitoSino { get; set; }
        public string FlgStatoNota { get; set; }
        public string FlgCausaleNota { get; set; }
        public int? IdAttivita { get; set; }
        public int? IdUtenteInserimento { get; set; }
        public string FlgAzioneDiarioAntifrode { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public int? IdCompagniaMand { get; set; }
        public DateTime? DtNotaPubblica { get; set; }
        public string FlgAutomaticaSino { get; set; }
        public int? IdEntitaDiarioPadre { get; set; }
    }
}
