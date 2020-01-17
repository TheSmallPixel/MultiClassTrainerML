using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepAttivazioneReport
    {
        public int KeyRepAttivazioneReport { get; set; }
        public int IdRepAttivazioneReport { get; set; }
        public int IdModello { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoOggettoStampa { get; set; }
        public string FlgAssicurato { get; set; }
        public string FlgContraente { get; set; }
        public string FlgControparte { get; set; }
        public string FlgAperturaSinistro { get; set; }
        public string FlgRecuperiRateali { get; set; }
        public string FlgLetteraSurr { get; set; }
        public string FlgInibizioneStampaSurr { get; set; }
        public string FlgIndennizzoTotContabil { get; set; }
        public string FlgLetteraEredi { get; set; }
        public string FlgInibizioneStampaEredi { get; set; }
        public string FlgDichiarazioneRicevuta { get; set; }
        public string FlgRecuperiDaContabil { get; set; }
        public string FlgIndennizzoDaQuietanza { get; set; }
        public string FlgIndirizzoIndennizzo { get; set; }
        public string FlgEntitaDaAnia { get; set; }
        public string FlgVisualizzazione { get; set; }
        public string FlgModifica { get; set; }
        public string FlgAttivato { get; set; }
        public string FlgFirmaCai { get; set; }
        public string FlgStatoRecupero { get; set; }
        public string FlgTipoRuoloUtente { get; set; }
        public string FlgTipoIncarico { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoCard { get; set; }
        public int? LivelloVisibilita { get; set; }
        public string FlgTipoRecupero { get; set; }
        public string FlgTrattamentoQuietanza { get; set; }
        public string FlgTrattamentoIndennizzo { get; set; }
        public string FlgSinistroMalattia { get; set; }
        public string FlgCodiceStampaUnivoco { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string FlgOmettiIndAgeSino { get; set; }
        public int? IdCompagnia { get; set; }
        public string FlgDerogabileSino { get; set; }
        public int? LivelloAutorizzazione { get; set; }
    }
}
