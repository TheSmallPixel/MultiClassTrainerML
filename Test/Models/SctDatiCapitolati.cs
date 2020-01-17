using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SctDatiCapitolati
    {
        public decimal KeySctDatiCapitolato { get; set; }
        public decimal IdSctDatiCapitolato { get; set; }
        public decimal IdSctCapitolato { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdPrSezione { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? PctMaxSconto { get; set; }
        public decimal? PctMaxAumento { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? ImpMaxSconto { get; set; }
        public decimal? ImpMaxAumento { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public string FlgDerogaAumentoSino { get; set; }
        public decimal? CodDerogaAumento { get; set; }
        public string FlgMomentoSconto { get; set; }
        public int? IdFormulaPremioConsigliato { get; set; }

        public virtual SctCapitolati IdSctCapitolatoNavigation { get; set; }
    }
}
