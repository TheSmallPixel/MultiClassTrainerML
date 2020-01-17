using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMezziPagCc
    {
        public int IdTabella { get; set; }
        public int? IdCompagnia { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public string FlgTipologiaCard { get; set; }
        public DateTime? DataInizioValidita { get; set; }
        public DateTime? DataFineValidita { get; set; }
        public int? IdContocorrente { get; set; }
        public string FlgParcellaSino { get; set; }
        public string FlgRamoTecnico { get; set; }
    }
}
