using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabContoSap
    {
        public int IdContoSap { get; set; }
        public string FlgAnnoCorrenteSino { get; set; }
        public string FlgTipoCard { get; set; }
        public string FlgTipoPagamento { get; set; }
        public string FlgStornoSino { get; set; }
        public string CodCompagniaAnia { get; set; }
        public string FlgEntePagatore { get; set; }
        public string CodCoordinateBancarie { get; set; }
        public string FlgTipoCoass { get; set; }
        public string CodContoDare { get; set; }
        public string CodContoAvere { get; set; }
        public string CodContoDareCoass1 { get; set; }
        public string CodContoDareCoass2 { get; set; }
        public string CodContoDareCoass3 { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtScadenza { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
