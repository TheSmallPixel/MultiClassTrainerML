using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaPianiClr
    {
        public int KeyRetevenditaPianoClr { get; set; }
        public int IdRetevenditaPianoClr { get; set; }
        public int IdRetevendita { get; set; }
        public string FlgTipoPianoClr { get; set; }
        public DateTime DtInizioPiano { get; set; }
        public DateTime DtFinePiano { get; set; }
        public DateTime DtInserimentoPiano { get; set; }
        public DateTime? DtChiusuraAnticipata { get; set; }
        public string FlgTipoProgrammaClr { get; set; }
        public decimal? ContributoAvviamento { get; set; }
        public string FlgSogliaAccessoDanni { get; set; }
        public string FlgSogliaAccessoVita { get; set; }
        public string SogliaAltro { get; set; }
        public string FlgMatriceConsuntPiano { get; set; }
        public string MatriceConsuntAltro { get; set; }
        public string Note { get; set; }
        public string FlgConsuntIncrementaleSino { get; set; }
        public string FlgStatoPianoClr { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdAnagrafica { get; set; }
        public string FlgAltreIncentivazioni { get; set; }
        public string FlgClausolaSalvaguardia { get; set; }
        public string SogliaAltroVita { get; set; }
        public DateTime? DtFinePianoOriginale { get; set; }
    }
}
