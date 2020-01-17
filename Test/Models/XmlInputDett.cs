using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputDett
    {
        public decimal IdXmlInputDett { get; set; }
        public decimal IdXmlInput { get; set; }
        public string FlgStato { get; set; }
        public string FlgTipoAzione { get; set; }
        public DateTime DtOperazione { get; set; }
        public string NumeroSinistro { get; set; }
        public decimal AnnoSinistro { get; set; }
        public string XmlSinistro { get; set; }
        public decimal? ProgrAzione { get; set; }
        public DateTime? DtImportazione { get; set; }
        public int? IdMovimento { get; set; }
        public string FlgTipoOggetto { get; set; }

        public virtual XmlInput IdXmlInputNavigation { get; set; }
    }
}
