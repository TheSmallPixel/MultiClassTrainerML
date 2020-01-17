using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcParametriStampa
    {
        public int IdParametroStampa { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgArchiviazioneSino { get; set; }
        public string FlgFascicolazioneSino { get; set; }
        public string FlgCartaIntestataSino { get; set; }
        public string FlgAvvisoEmailSino { get; set; }
        public string DtCreazione { get; set; }
        public int? IdLinguaReport { get; set; }
        public int? IdFormatoReport { get; set; }
        public int? IdUtenteReport { get; set; }
        public int? IdModelloReport { get; set; }
        public string Etichetta { get; set; }
        public string ParametriDataset { get; set; }
        public string OggettoMail { get; set; }
        public string TestoMail { get; set; }
        public int? IdDeroga { get; set; }
        public int? IdOggettoPadre { get; set; }
        public string FlgTipoOggettoPadre { get; set; }
    }
}
