using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommaCheckinRisposte
    {
        public int KeyCommaCheckinRisposta { get; set; }
        public int IdCommaCheckinRisposta { get; set; }
        public int IdCommaCheckinRichiesta { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdOggetto { get; set; }
        public string IdentFonteSoggetto { get; set; }
        public string IdentSoggetto { get; set; }
        public string Denominazione { get; set; }
        public string FlgTipoDenominazione { get; set; }
        public string DenominazioneOriginale { get; set; }
        public string FlgTipoSoggetto { get; set; }
        public string FlgStatoSoggetto { get; set; }
        public string FlgAnnullatoSino { get; set; }
        public int? Progressivo { get; set; }
        public int? Vicinanza { get; set; }
        public DateTime? DtInserimento { get; set; }
        public DateTime? DtUltimoAggiornamento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
