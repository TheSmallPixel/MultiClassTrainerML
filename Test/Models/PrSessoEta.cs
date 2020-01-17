using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrSessoEta
    {
        public decimal KeyPrSessoEta { get; set; }
        public decimal IdPrSessoEta { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public string FlgSesso { get; set; }
        public decimal? EtaDa { get; set; }
        public decimal? EtaA { get; set; }
        public string FlgAssumibileSino { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public decimal? ImpSessoEta { get; set; }
        public decimal? CoefSessoEta { get; set; }
        public decimal? PuntiSessoEta { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
