using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInput
    {
        public XmlInput()
        {
            XmlInputDett = new HashSet<XmlInputDett>();
            XmlInputErr = new HashSet<XmlInputErr>();
        }

        public decimal IdXmlInput { get; set; }
        public DateTime DtFlussoXml { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? ProgrGiornata { get; set; }
        public string FlgStato { get; set; }
        public string FlgProvenienza { get; set; }
        public string NomeFile { get; set; }

        public virtual ICollection<XmlInputDett> XmlInputDett { get; set; }
        public virtual ICollection<XmlInputErr> XmlInputErr { get; set; }
    }
}
