using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiOggettoCard
    {
        public int IdTipoOggettoCard { get; set; }
        public int IdTipoOggetto { get; set; }
        public string FlgMacrotipologiaCard { get; set; }
        public string FlgInputWebSino { get; set; }
        public string FlgInputB2bSino { get; set; }
        public string FlgOutputDatiSino { get; set; }
        public string FlgOutputAllegatiSino { get; set; }
        public string FlgTipoCalendarioAnia { get; set; }
    }
}
