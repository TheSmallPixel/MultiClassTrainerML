using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabOperazioniFeu
    {
        public int IdOperazioneFeu { get; set; }
        public int CodOperazioneFeu { get; set; }
        public int? CodOperazioneWise { get; set; }
        public string FlgTipoEvento { get; set; }
        public string TipoMenu { get; set; }
        public string FlgTipoOperazioneBe { get; set; }
        public string DescOperazione { get; set; }
    }
}
