using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabStatiEquivalentiCard
    {
        public int IdStatoEquivalenteCard { get; set; }
        public int? IdStatoAttualeRich { get; set; }
        public int? IdStatoDestinazioneRich { get; set; }
        public int? IdStatoAttualeReale { get; set; }
        public int? IdStatoDestinazioneEquiv { get; set; }
    }
}
