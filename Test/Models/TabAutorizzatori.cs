using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAutorizzatori
    {
        public decimal IdAutorizzatore { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdProdotto { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? IdRetevenditaControllata { get; set; }
        public decimal IdUtenteAutorizzatore { get; set; }
    }
}
