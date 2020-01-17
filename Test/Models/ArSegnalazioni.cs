using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArSegnalazioni
    {
        public int IdSegnalazioneAr { get; set; }
        public string FlgTipoSegnalazione { get; set; }
        public string DtEvento { get; set; }
        public DateTime? DtEffettoEvento { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public string NSinistro { get; set; }
        public int? AnnoEsercizio { get; set; }
        public decimal? ImpLiquidazione { get; set; }
        public string MotivoAnnullamento { get; set; }
        public string NominativoContraente { get; set; }
        public string NominativoAssicurato { get; set; }
        public string NominativoBeneficiario { get; set; }
    }
}
