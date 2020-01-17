using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MfDati
    {
        public decimal KeyMfDato { get; set; }
        public decimal IdMfDato { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal Anno { get; set; }
        public decimal Progressivo { get; set; }
        public decimal IdAgenzia { get; set; }
        public decimal IdMfCausale { get; set; }
        public decimal ImpEntrate { get; set; }
        public decimal ImpUscite { get; set; }
        public decimal IdValuta { get; set; }
        public string Note { get; set; }
        public DateTime? DtSysRegistrazione { get; set; }
        public DateTime? DtCompetenza { get; set; }
        public DateTime? DtRendiconto { get; set; }
        public DateTime? DtValuta { get; set; }
        public decimal? IdContocorrente { get; set; }
        public string RifTransazione { get; set; }
        public string FlgStatoMv { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string Versione { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtScaricoContabile { get; set; }

        public virtual MfCausali IdMfCausaleNavigation { get; set; }
    }
}
