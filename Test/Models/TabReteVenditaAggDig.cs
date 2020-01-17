using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAggDig
    {
        public int KeyAggDig { get; set; }
        public int IdAggDig { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public string AltroSitoAgenzia { get; set; }
        public string ProfiloFbStdAxa { get; set; }
        public string AltroProfiloFbAgenzia { get; set; }
        public string GoogleMyBusinessSino { get; set; }
        public string AltroProfiloSocial { get; set; }
        public DateTime? DtChiusuraFerieDal { get; set; }
        public DateTime? DtChiusuraFerieAl { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
