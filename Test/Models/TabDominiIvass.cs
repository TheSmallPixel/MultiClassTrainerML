using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDominiIvass
    {
        public int IdTabDominiIvass { get; set; }
        public int IdUtente { get; set; }
        public string CodWise { get; set; }
        public string CodDominio { get; set; }
        public string DescDominio { get; set; }
        public DateTime? DtUltAggiornDominio { get; set; }
        public string CodValore { get; set; }
        public string DescValore { get; set; }
        public DateTime? DtUltAggiornValore { get; set; }
    }
}
