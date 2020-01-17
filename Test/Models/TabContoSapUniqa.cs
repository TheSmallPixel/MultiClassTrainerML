using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabContoSapUniqa
    {
        public int IdContoSapUniqa { get; set; }
        public string ContoEconomico { get; set; }
        public string ContoAnalitico { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgAnnoCorrenteSino { get; set; }
        public string MezzoPagamentoWise { get; set; }
        public string TipoCaricamentoWise { get; set; }
        public string StornoSino { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtScadenza { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
        public string FlgTipoOggetto2 { get; set; }
        public string TipoGestione { get; set; }
        public string TipoContoFg { get; set; }
        public int? Ramo { get; set; }
        public string TipoCtt { get; set; }
    }
}
