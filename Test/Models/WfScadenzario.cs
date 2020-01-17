using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfScadenzario
    {
        public decimal IdScadenzario { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdOggetto { get; set; }
        public DateTime? DtInserimentoPromemoria { get; set; }
        public DateTime? DtScadenzaPromemoria { get; set; }
        public string Descrizione { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgAttivoSino { get; set; }
        public string FlgTipoAlert { get; set; }
        public string FlgTipoOggetto { get; set; }
    }
}
