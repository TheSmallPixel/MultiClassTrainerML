using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepLetterePostel
    {
        public decimal IdLettera { get; set; }
        public decimal IdSinistro { get; set; }
        public string NSinistro { get; set; }
        public decimal? IdEntitacoinvolta { get; set; }
        public string FlgTipoDocumento { get; set; }
        public DateTime DataCreazione { get; set; }
        public string TestoInviato { get; set; }
        public string RagSocialeDestinatario { get; set; }
        public string IndirizzoDestinatario { get; set; }
        public string RuoloDestinatario { get; set; }
        public decimal? IdAnagDestinatario { get; set; }
        public string FlgErroreSino { get; set; }
        public string CodErrore { get; set; }
        public string FlgTipoInvio { get; set; }
        public int? IdUtente { get; set; }
        public int? IdModello { get; set; }
        public string MetodoCreazioneDataset { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgStatoPostel { get; set; }
        public int? IdOggetto { get; set; }
    }
}
