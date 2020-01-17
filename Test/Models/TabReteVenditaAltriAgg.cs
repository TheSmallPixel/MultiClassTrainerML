using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAltriAgg
    {
        public decimal KeyRetevenditaAltriAgg { get; set; }
        public decimal IdRetevenditaAltriAgg { get; set; }
        public string FlgSegStra { get; set; }
        public string FlgSegTat { get; set; }
        public string FlgAnnullamentoSino { get; set; }
        public DateTime? DtAnnDal { get; set; }
        public DateTime? DtAnnAl { get; set; }
        public string FlgDoppioMandatoSino { get; set; }
        public string FlgLiberalizzazioneSino { get; set; }
        public DateTime? DtDoppioMandatoDal { get; set; }
        public decimal? IdAgenziaCorrelato { get; set; }
        public decimal? NumPostAssegnati { get; set; }
        public decimal? NumPostSpett { get; set; }
        public string FlgTargheCompagniaSino { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string IbanAccredito { get; set; }
        public string FlgCodiceRaSap { get; set; }
        public string CodiceAnaSap { get; set; }
        public string EMailEstrattoConto { get; set; }
        public string FlgRitAcconto { get; set; }
        public string FlgAccordoDigitale { get; set; }
        public string FlgVersAccordoDigitale { get; set; }
        public string FlgAccordoDati { get; set; }
        public string FlgVersAccordoDati { get; set; }
        public string FlgAccordoSinistri { get; set; }
        public string FlgVersAccordoSinistri { get; set; }
        public string FlgAgeAbilCrm { get; set; }
        public int? NumMaxLicDispExtVend { get; set; }
        public int? NumMaxLicVend { get; set; }
        public int? NumMaxLicExtVend { get; set; }
        public string FlgGeoAxaSino { get; set; }
        public string FlgGeoAgeSino { get; set; }
        public decimal? ImpIda { get; set; }
        public string FlgTargaInsegnaNodo { get; set; }
        public string FlgRinnoviOnlineSuCc { get; set; }
    }
}
