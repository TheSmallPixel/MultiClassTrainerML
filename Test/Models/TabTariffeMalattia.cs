using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTariffeMalattia
    {
        public int KeyTariffaMalattia { get; set; }
        public int IdTariffaMalattia { get; set; }
        public string CodTariffa { get; set; }
        public string CodGruppoTariffa { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string Cdtarest { get; set; }
    }
}
