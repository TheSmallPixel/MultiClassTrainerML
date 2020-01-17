using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AiaNotificheSin
    {
        public int KeyNotificheSin { get; set; }
        public int IdNotificheSin { get; set; }
        public string CodNotif { get; set; }
        public string CodUniSini { get; set; }
        public string CodSinistro { get; set; }
        public int? IdSinistro { get; set; }
        public DateTime DataAccad { get; set; }
        public decimal Score { get; set; }
        public decimal? Vscore { get; set; }
        public decimal? ScoreVeic { get; set; }
        public decimal? ScoreCoinv { get; set; }
        public decimal? ScoreInteres { get; set; }
        public decimal? ScoreContrat { get; set; }
        public decimal Qscore { get; set; }
        public string FlgAutorita { get; set; }
        public string FlgBlackBox { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
