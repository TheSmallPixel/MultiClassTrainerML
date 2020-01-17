using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepModelliPostalizzatori
    {
        public int IdModellopostalizzatore { get; set; }
        public int IdModello { get; set; }
        public string FlgSistemaPostalizzazione { get; set; }
        public string FlgTipoPostalizzazione { get; set; }
        public string FlgSistemaDefaultSino { get; set; }
    }
}
