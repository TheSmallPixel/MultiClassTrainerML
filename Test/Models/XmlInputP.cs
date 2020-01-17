using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputP
    {
        public XmlInputP()
        {
            XmlInputErrP = new HashSet<XmlInputErrP>();
        }

        public decimal IdXmlInput { get; set; }
        public DateTime? DtFlussoXml { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? ProgrGiornata { get; set; }
        public string FlgStato { get; set; }
        public string FlgProvenienza { get; set; }

        public virtual ICollection<XmlInputErrP> XmlInputErrP { get; set; }
    }
}
