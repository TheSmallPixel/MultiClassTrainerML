using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrvDatiCapitolati
    {
        public decimal KeyPrvDatiCapitolato { get; set; }
        public decimal? IdPrvDatiCapitolato { get; set; }
        public decimal? IdPrvCapitolato { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public string ValoreParametri { get; set; }
        public string FlgModProv { get; set; }
        public string FlgMomentoProv { get; set; }
        public string Note { get; set; }
        public decimal? PctAcquisto { get; set; }
        public decimal? PctIncasso { get; set; }
        public decimal? PctAcquistoAccessori { get; set; }
        public decimal? PctIncassoAccessori { get; set; }
        public decimal? ImpAcquisto { get; set; }
        public decimal? ImpIncasso { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdFormula { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgDerogaOperazioneSino { get; set; }
        public decimal? CodDerogaOperazione { get; set; }
        public string FlgDerogaRateSuccSino { get; set; }
        public decimal? CodDerogaRateSucc { get; set; }

        public virtual PrvCapitolati IdPrvCapitolatoNavigation { get; set; }
    }
}
