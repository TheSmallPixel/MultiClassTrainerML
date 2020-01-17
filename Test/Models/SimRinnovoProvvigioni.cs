using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SimRinnovoProvvigioni
    {
        public int KeySimRinnovoProvv { get; set; }
        public int IdSimRinnovoProvv { get; set; }
        public int? IdSimRinnovoGar { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdRetevendita { get; set; }
        public int? Livello { get; set; }
        public int? IdUtente { get; set; }
        public decimal? ImpProvvAcquistoGar { get; set; }
        public decimal? ImpProvvIncassoGar { get; set; }
        public decimal? ImpProvvAcquistoAcc { get; set; }
        public decimal? ImpProvvIncassoAcc { get; set; }
    }
}
