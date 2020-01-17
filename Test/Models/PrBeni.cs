using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrBeni
    {
        public decimal KeyPrBene { get; set; }
        public decimal IdPrBene { get; set; }
        public decimal IdPrProdotto { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgTipoBene { get; set; }
        public decimal NMinBeni { get; set; }
        public decimal NMaxBeni { get; set; }
        public string FlgNoteSino { get; set; }
        public string FlgGarObbSino { get; set; }
        public string FlgAssicuratoContraente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgRichiediDebitoreSino { get; set; }
        public string FlgDatiRischioImpiegoSino { get; set; }
        public string FlgRichiediMandatariaSino { get; set; }
        public string FlgDerogaMaxBeniSino { get; set; }
        public decimal? CodDerogaMaxBeni { get; set; }
        public string FlgNumeroCertificatoSino { get; set; }
        public int? EtaMaxAssicurato { get; set; }
        public int? EtaMaxRinnovo { get; set; }
        public string FlgDerogaEtaAssicurato { get; set; }
        public decimal? CodDerogaEtaAssicurato { get; set; }
        public string FlgAbilMultiPrApertiSino { get; set; }
        public string FlgRicGrTerContraSino { get; set; }
        public int? EtaSegnalazioneAssicurato { get; set; }
        public string FlgDisabilInclusioneSino { get; set; }
        public string FlgDisabilEsclusioneSino { get; set; }
        public string TestoBeneGenerico { get; set; }
        public string TooltipInfo { get; set; }
    }
}
