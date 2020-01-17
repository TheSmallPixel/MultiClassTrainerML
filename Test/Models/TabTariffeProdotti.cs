using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTariffeProdotti
    {
        public int IdTariffaProdotto { get; set; }
        public string FlgTipoTabellaTariffeAxa { get; set; }
        public decimal? AnnoIncentivazione { get; set; }
        public string CodTariffa { get; set; }
        public string FlgTipologiaProdottoAxa { get; set; }
        public string DescTariffa { get; set; }
        public DateTime? DtInserimento { get; set; }
        public DateTime? DtAggiornamento { get; set; }
        public DateTime? DtCancellazione { get; set; }
        public int? IdUtenteInserimento { get; set; }
        public int? IdUtenteAggiornamento { get; set; }
        public string FlgValidoSino { get; set; }
    }
}
