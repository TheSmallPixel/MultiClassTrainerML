using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputErrP
    {
        public decimal IdXmlInputErr { get; set; }
        public decimal IdXmlInput { get; set; }
        public string CodErrore { get; set; }

        public virtual XmlInputP IdXmlInputNavigation { get; set; }
    }
}
