using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2DatiGenerali
    {
        public decimal KeyDp2DatiGenerali { get; set; }
        public decimal IdDp2DatiGenerali { get; set; }
        public decimal? IdDp2Dossier { get; set; }
        public decimal IdRetevendita { get; set; }
        public string CodiceOmnia { get; set; }
        public DateTime DtInserimento { get; set; }
        public string FlgInquadramento { get; set; }
        public string FlgAnzianita { get; set; }
        public string FlgStato { get; set; }
        public DateTime? DtRitiro { get; set; }
        public string MotivoRitiro { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal? IdDp2PianoContr { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
