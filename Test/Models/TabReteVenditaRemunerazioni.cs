using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaRemunerazioni
    {
        public decimal KeyRemunerazione { get; set; }
        public decimal IdRemunerazione { get; set; }
        public decimal IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public string FlgAdesione16magSino { get; set; }
        public string FlgAdesioneIncSolSino { get; set; }
        public string FlgRinunciaVecIstSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
    }
}
