using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RispostaSic
    {
        public int IdRispostaSic { get; set; }
        public string ProtocolloSic { get; set; }
        public string DatiInput { get; set; }
        public string TipoErrore { get; set; }
        public int? CodErrore { get; set; }
        public string MessaggioErrore { get; set; }
        public string RispostaOnline { get; set; }
        public string MessaggioRispostaOnline { get; set; }
        public string RispostaOffline { get; set; }
        public string MessaggioRispostaOffline { get; set; }
        public string DescrizioneImpresaMandataria { get; set; }
        public string DescrizioneTipoVeicMandat { get; set; }
        public int? IdDatiVeicMandataria { get; set; }
        public string FlagSinCardMandat { get; set; }
        public string DescrizioneImpresaDebitrice { get; set; }
        public string DescrizioneTipoVeicDeb { get; set; }
        public int? IdDatiVeicDebitrice { get; set; }
        public string FlagSinCardDeb { get; set; }
        public int? NumSinCardVeicMand { get; set; }
        public int? NumSinCardVeicDeb { get; set; }
    }
}
