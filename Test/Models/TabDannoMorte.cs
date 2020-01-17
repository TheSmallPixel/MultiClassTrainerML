using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDannoMorte
    {
        public int IdDannoMorte { get; set; }
        public int IdDannoBiologico { get; set; }
        public string FlgTipoRelazioneParentela { get; set; }
        public decimal ImpMinimo { get; set; }
        public decimal ImpMassimo { get; set; }
    }
}
