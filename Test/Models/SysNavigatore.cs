using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysNavigatore
    {
        public decimal IdNavigatore { get; set; }
        public string FlgTipoNavigatore { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal Step { get; set; }
        public string FlgDisabilitatoSino { get; set; }
        public decimal? Codice { get; set; }
        public string Descrizione { get; set; }
    }
}
