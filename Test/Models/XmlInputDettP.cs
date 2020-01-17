using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputDettP
    {
        public decimal IdXmlInputDett { get; set; }
        public decimal IdXmlInput { get; set; }
        public string FlgStato { get; set; }
        public string FlgTipoAzione { get; set; }
        public DateTime? DtOperazione { get; set; }
        public string NumeroPolizza { get; set; }
        public decimal IdProdotto { get; set; }
        public decimal? IdRetevendita { get; set; }
        public string XmlPolizza { get; set; }
        public decimal? ProgrAzione { get; set; }
        public string TimestampFineElaborazione { get; set; }
        public string TimestampInizioElaborazione { get; set; }
    }
}
