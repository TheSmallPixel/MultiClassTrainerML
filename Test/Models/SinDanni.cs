using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDanni
    {
        public int KeyDanno { get; set; }
        public int IdDanno { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public string FlgTipologiaDanno { get; set; }
        public DateTime? DtApertura { get; set; }
        public DateTime? DtRichiestaDanni { get; set; }
        public string FlgTipologiaGestioneCard { get; set; }
        public string FlgStato { get; set; }
        public string NoteStato { get; set; }
        public DateTime? DtStato { get; set; }
        public string FlgStatoGestionale { get; set; }
        public DateTime? DtStatoGestionale { get; set; }
        public string FlgCausaleChiusura { get; set; }
        public string FlgForzaturaRcaSino { get; set; }
        public string FlgCauDanno { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public decimal? ImpRiservaGestionale { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgFittizioSino { get; set; }
    }
}
