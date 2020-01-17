using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDerogheRandom
    {
        public int KeyDerogheRandom { get; set; }
        public int IdDerogheRandom { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int IdCompagnia { get; set; }
        public int? IdUtentemonitorato { get; set; }
        public string MonitorareSino { get; set; }
        public string TipoAzioneXml { get; set; }
        public DateTime? DtInizioMonitoraggio { get; set; }
        public int? GiorniMonitoraggio { get; set; }
        public int? TotDerogheRandom { get; set; }
        public int? Deroghexgiorni { get; set; }
        public int? Xgiorni { get; set; }
        public DateTime? DtUltimaDeroga { get; set; }
        public int? NumUltimaDeroga { get; set; }
    }
}
