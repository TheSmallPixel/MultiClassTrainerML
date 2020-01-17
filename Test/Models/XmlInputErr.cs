using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class XmlInputErr
    {
        public decimal IdXmlInputErr { get; set; }
        public decimal IdXmlInput { get; set; }
        public string CodErrore { get; set; }

        public virtual XmlInput IdXmlInputNavigation { get; set; }
    }
}
