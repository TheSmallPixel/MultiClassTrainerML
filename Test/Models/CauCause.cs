using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CauCause
    {
        public decimal KeyCausa { get; set; }
        public decimal IdCausa { get; set; }
        public DateTime? DtCostituzioneCausa { get; set; }
        public DateTime? DtEsitoCausa { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgEsitoCausa { get; set; }
        public string FlgTipoCausa { get; set; }
        public string FlgTipoCuria { get; set; }
        public string FlgTipoGrado { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Note { get; set; }
        public decimal IdCitazione { get; set; }
        public decimal IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? Protocollo { get; set; }
        public DateTime? DtPrimaUdienza { get; set; }
        public int? IdLegale { get; set; }
        public int? IdAttore { get; set; }
        public int? IdIncarico { get; set; }
        public string DannoCoseSino { get; set; }
        public string DannoLesioniSino { get; set; }
        public string DannoVeicoloSino { get; set; }
        public decimal? ImpPetitumCose { get; set; }
        public decimal? ImpPetitumLesioni { get; set; }
        public decimal? ImpPetitumVeicolo { get; set; }
        public decimal? ImpSentenziato { get; set; }
        public decimal? ImpSpeseLegaliCtp { get; set; }
        public decimal? ImpSpeseResistenza { get; set; }
        public string FlgStatoCausa { get; set; }
        public string FlgContenziosoRcSino { get; set; }
    }
}
