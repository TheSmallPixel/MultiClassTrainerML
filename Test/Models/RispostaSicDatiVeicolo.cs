using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RispostaSicDatiVeicolo
    {
        public int IdSicDatiVeicolo { get; set; }
        public string Telaio { get; set; }
        public string CodiceOmologazione { get; set; }
        public string DescrizioneVeicolo { get; set; }
        public string Classe { get; set; }
        public string Uso { get; set; }
        public int? PotenzaCv { get; set; }
        public decimal? PotenzaKw { get; set; }
        public int? Cc { get; set; }
        public int? NumeroPosti { get; set; }
        public int? PortataKg { get; set; }
    }
}
