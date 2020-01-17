using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfBeni
    {
        public decimal KeyBene { get; set; }
        public decimal? IdBene { get; set; }
        public string NoteBeneNc { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdAssicurato { get; set; }
        public decimal? IdUbicazione { get; set; }
        public decimal? IdVeicoloassicurato { get; set; }
        public string FlgTipoBene { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdPolizza { get; set; }
        public string IdEsternoBene { get; set; }
        public decimal? IdDebitore { get; set; }
        public DateTime? DtAssicuratoDal { get; set; }
        public DateTime? DtEsclusione { get; set; }
        public string IdentificativoNucleo { get; set; }
        public int? IdAnagraficaCapoNucleo { get; set; }
        public DateTime? DtPrenotazioneViaggio { get; set; }
        public DateTime? DtPartenzaViaggio { get; set; }
        public DateTime? DtRientroViaggio { get; set; }
    }
}
