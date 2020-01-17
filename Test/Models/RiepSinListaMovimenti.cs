using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RiepSinListaMovimenti
    {
        public decimal IdListaMovimenti { get; set; }
        public DateTime? DtRiferimento { get; set; }
        public string FlgDefinitivoSino { get; set; }
        public decimal? IdSinistroOrigine { get; set; }
        public decimal? IdEntitacoinvoltaOrigine { get; set; }
        public string FlgTipologiaGestione { get; set; }
        public string FlgTipoDanno { get; set; }
        public decimal? IdStatoFinale { get; set; }
        public decimal? IdMovimento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public decimal? Importo { get; set; }
        public decimal? ImportoForfaitCard { get; set; }
        public string FlgStornoSino { get; set; }
        public string FlgChiudeSinistroSino { get; set; }
        public string FlgChiudeTipoCardSino { get; set; }
        public string FlgChiudeTipoDannoSino { get; set; }
        public string FlgCausaSino { get; set; }
        public string FlgTipoMovimento { get; set; }
        public string FlgTipoMovimento2 { get; set; }
        public string FlgTipoRiserva { get; set; }
        public string FlgTipoRiserva2 { get; set; }
        public decimal? IdBeneficiario { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string Beneficiario { get; set; }
        public decimal? ImpRiservaCadutaCose { get; set; }
        public decimal? ImpRiservaCadutaPers { get; set; }
        public decimal? ImpIndennizziVeicoli { get; set; }
        public decimal? ImpIndennizziTrasM { get; set; }
        public decimal? ImpIndennizziTrasF { get; set; }
        public decimal? ImpIndennizziPassM { get; set; }
        public decimal? ImpIndennizziPassF { get; set; }
        public decimal? ImpIndennizziCose { get; set; }
        public decimal? ImportoSpese { get; set; }
        public decimal? ImportoRecuperi { get; set; }
        public string FlgQuietanzaSeparataSino { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public decimal? IdMovimentoStornato { get; set; }
        public string IbanCompagnia { get; set; }
        public string FlgStornoContabileSino { get; set; }
        public string IdEsternoMovimento { get; set; }
        public string Danno { get; set; }
    }
}
