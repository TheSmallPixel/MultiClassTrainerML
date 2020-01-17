using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaPianiClrPer
    {
        public int KeyRetevenditaPianoClrPer { get; set; }
        public int IdRetevenditaPianoClrPer { get; set; }
        public int IdRetevenditaPianoClr { get; set; }
        public DateTime DtInizio { get; set; }
        public DateTime DtFine { get; set; }
        public decimal ImpTotDanni { get; set; }
        public decimal ImpDiCuiNonAuto { get; set; }
        public decimal ImpTotVita { get; set; }
        public string FlgTipoRateizzazioneContr { get; set; }
        public decimal? ImpContrUT { get; set; }
        public decimal? ImpContrAnnAnt { get; set; }
        public decimal ImpRata { get; set; }
        public decimal ImpTotaleContributi { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? ImpRata1 { get; set; }
        public decimal? ImpRata2 { get; set; }
        public decimal? ImpRata3 { get; set; }
        public decimal? ImpRata4 { get; set; }
    }
}
