using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaCapRe
    {
        public int KeyRetevenditaCapRe { get; set; }
        public int IdRetevenditaCapRe { get; set; }
        public string FlgTipoListino { get; set; }
        public string FlgTipoRegimeProvv { get; set; }
        public string FlgTipoDiritti { get; set; }
        public string FlgTipoRicDiritti { get; set; }
        public string FlgTipoListinoAcc { get; set; }
        public string FlgStornoProvvigioniSino { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
