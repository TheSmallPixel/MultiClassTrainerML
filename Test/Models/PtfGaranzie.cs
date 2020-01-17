using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfGaranzie
    {
        public decimal KeyGaranziaassicurata { get; set; }
        public decimal IdGaranziaassicurata { get; set; }
        public decimal IdGaranzia { get; set; }
        public decimal? ImpCapitaleAssicurato { get; set; }
        public decimal? ImpMaxSinistro { get; set; }
        public decimal? ImpMaxCose { get; set; }
        public decimal? ImpMaxPersona { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? ImpMinScoperto { get; set; }
        public decimal? PerScoperto { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpMaxInterruzioneAttivita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValutaCapitaleAssicurato { get; set; }
        public decimal? IdValutaMaxSinistro { get; set; }
        public decimal? IdValutaMaxCose { get; set; }
        public decimal? IdValutaMaxPersona { get; set; }
        public decimal? IdValutaFranchigia { get; set; }
        public decimal? IdValutaMinScoperto { get; set; }
        public decimal? IdValutaMaxInterruzioneAtt { get; set; }
        public decimal? IdBene { get; set; }
        public int? NPrestErogabiliPerAnnAss { get; set; }
        public string CodTariffa { get; set; }
        public string FlgTipoMassimalizzazione { get; set; }
        public string ClassificazioneGaranzia { get; set; }
        public decimal? ImpCapitaleAssicurato2 { get; set; }
    }
}
