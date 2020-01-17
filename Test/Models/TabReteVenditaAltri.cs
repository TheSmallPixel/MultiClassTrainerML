using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAltri
    {
        public decimal KeyRetevenditaAltri { get; set; }
        public decimal IdRetevenditaAltri { get; set; }
        public decimal? PerSpMedioUltimiEsercizi { get; set; }
        public string Note { get; set; }
        public string FlgMobiliCompagniaSino { get; set; }
        public string FlgInsegnaCompagniaSino { get; set; }
        public string FlgTitolaritaLocazione { get; set; }
        public string FlgProprietaLocali { get; set; }
        public string FlgTipoMeccaniz { get; set; }
        public string FlgTipoMonetizzazione { get; set; }
        public string FlgPlSinistriRcaSino { get; set; }
        public string FlgPlSinistriArdSino { get; set; }
        public string FlgPlSinistriInfSino { get; set; }
        public string FlgPlSinistriIncSino { get; set; }
        public string ClusterUltimoEs { get; set; }
        public string IntegGaaiVariabSino { get; set; }
        public string IntegGaaiGarantSino { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? ImpCauzionePrestata { get; set; }
        public DateTime? DtCauzioneDal { get; set; }
        public string FlgTipoCauzione { get; set; }
        public string FlgLiberalizzazionePtf { get; set; }
        public DateTime? DtLiberalizzazionePtfDal { get; set; }
        public DateTime? DtLiberalizzazionePtfAl { get; set; }
        public string FlgAutorizFondiSino { get; set; }
        public DateTime? DtAutorizFondi { get; set; }
        public string OldCodGestione { get; set; }
        public string OldCodReteVendita { get; set; }
        public string CodicePortafoglioAgenzia { get; set; }
        public string DescPortafoglioAgenzia { get; set; }
        public decimal? ImpScopertoCassaMin { get; set; }
        public decimal? ImpScopertoCassaMax { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgMeccanizzatoOmniaSino { get; set; }
        public string FlgMeccanizzatoAolSino { get; set; }
        public string FlgPartecipaUtiliSino { get; set; }
        public DateTime? DtPartecipaUtili { get; set; }
    }
}
