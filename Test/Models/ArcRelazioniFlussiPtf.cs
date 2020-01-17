using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRelazioniFlussiPtf
    {
        public int IdArcRelazioneflussoPtf { get; set; }
        public string FlgSistemaOrigine { get; set; }
        public string FlgTipoOperazione { get; set; }
        public string IdentificativoEsterno { get; set; }
        public int? PrgOperazione { get; set; }
        public string FlgTipoOggettoWise { get; set; }
        public int IdOggettoWise { get; set; }
        public int IdCompagnia { get; set; }
        public int? IdXmlInputDettP { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdPolizzaSospesa { get; set; }
        public int? IdPolizzaAnnullata { get; set; }
        public int? IdTitolo { get; set; }
        public int? KeyPolEvento { get; set; }
        public int? KeyTitEvento { get; set; }
        public string NPolizza { get; set; }
        public string PeriodoContabile { get; set; }
        public string TimestampInserimento { get; set; }
    }
}
