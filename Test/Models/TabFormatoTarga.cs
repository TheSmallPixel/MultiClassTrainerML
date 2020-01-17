using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFormatoTarga
    {
        public decimal IdFormatoTarga { get; set; }
        public string FlgTipoTarga { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public string FlgTargaSpeciale { get; set; }
        public string FormatoInputTarga { get; set; }
        public string FormatoOutputTarga { get; set; }
    }
}
