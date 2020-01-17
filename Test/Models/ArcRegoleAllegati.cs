using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRegoleAllegati
    {
        public int IdRegolaAllegato { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string FlgTipoMacrotipologia { get; set; }
        public string FlgTipoMicrotipologia { get; set; }
        public int? IdFormula { get; set; }
        public int IdUtente { get; set; }
        public string FlgObbligatorietaAllegato { get; set; }
        public string FlgTpRegolaSxApertura { get; set; }
        public string FlgTpRegolaSxLiquidaz { get; set; }
        public string FlgTpRegolaSottoscrizione { get; set; }
        public string FlgTipoOggetto { get; set; }
    }
}
