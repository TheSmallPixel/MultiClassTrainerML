using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistriMovimenti
    {
        public decimal KeyPolSinistroMovimento { get; set; }
        public decimal? IdPolSinistroMovimento { get; set; }
        public decimal? IdPolSinistro { get; set; }
        public decimal? IdPolizza { get; set; }
        public string ChiaveEsternaMovimento { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgTipoMovimentoSinistro { get; set; }
        public decimal? ImpMovimento { get; set; }
        public decimal? ImpProvvigioni { get; set; }
        public decimal? IdValuta { get; set; }
        public DateTime? DtOrdine { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string FlgConsentiIncassoSino { get; set; }
        public decimal? IdCntFogliocassa { get; set; }
        public DateTime? DtSysMovimento { get; set; }
        public string FlgMezzoPagamentoIncasso { get; set; }
        public string FlgStatoMovimento { get; set; }
        public decimal? IdAnagraficaBeneficiario { get; set; }
        public decimal? IdAnagraficaDebitore { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdPolSinistroPagatore { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
