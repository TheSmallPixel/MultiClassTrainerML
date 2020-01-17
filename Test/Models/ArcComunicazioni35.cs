using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcComunicazioni35
    {
        public int KeyComunicazione { get; set; }
        public int IdComunicazione { get; set; }
        public string FlgTipoComunicazione { get; set; }
        public DateTime DtEmissione { get; set; }
        public DateTime DtEffetto { get; set; }
        public string OggettoComunicazione { get; set; }
        public string TestoComunicazione { get; set; }
        public DateTime? DtEstrazione { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
