using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipoDocumentoDossierDes
    {
        public int IdTipodocumentodossierDes { get; set; }
        public int IdTipoDocumentoDossier { get; set; }
        public int IdAnagrafica { get; set; }
        public string FlgDestSino { get; set; }
        public string FlgCcSino { get; set; }
    }
}
