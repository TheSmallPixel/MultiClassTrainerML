using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAltriCol
    {
        public decimal KeyRetevenditaAltroCol { get; set; }
        public decimal IdRetevenditaAltroCol { get; set; }
        public string FlgPosizioneRuiInsRegSino { get; set; }
        public string FlgPosizioneRuiCesRegSino { get; set; }
        public string FlgMotivoCesCol { get; set; }
        public string FlgSedeAgenziaSino { get; set; }
        public string FlgPuntoRemotoSino { get; set; }
        public DateTime? DtBeneviso { get; set; }
        public DateTime? DtRevocaBeneviso { get; set; }
        public DateTime? DtRatifica { get; set; }
        public DateTime? DtRevocaRatifica { get; set; }
        public string FlgPianoClrSino { get; set; }
        public DateTime? DtPianoClrDal { get; set; }
        public DateTime? DtPianoClrAl { get; set; }
        public string FlgPlurimandatoSino { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? IdCompagniaPrec { get; set; }
        public decimal? IdCompagnia1 { get; set; }
        public decimal? IdCompagnia2 { get; set; }
    }
}
