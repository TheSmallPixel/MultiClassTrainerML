using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PvDati
    {
        public decimal KeyPvDato { get; set; }
        public decimal IdPvDato { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal AnnoPartita { get; set; }
        public decimal NPartita { get; set; }
        public decimal IdAgenzia { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtSysRegistrazione { get; set; }
        public decimal IdPvCausale { get; set; }
        public DateTime? CompetenzaEmesso { get; set; }
        public string FlgStatoPv { get; set; }
        public decimal? ImpDare { get; set; }
        public decimal? ImpAvere { get; set; }
        public string Note { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string Versione { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdCntRendiconto { get; set; }
        public decimal? IdTitEsito { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdMfPvAbbinamento { get; set; }
        public DateTime? DtScaricoContabile { get; set; }

        public virtual PvCausali IdPvCausaleNavigation { get; set; }
    }
}
