using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabErroriIsvap
    {
        public decimal IdErrore { get; set; }
        public string FlgTipoErrore { get; set; }
        public string CodErroreLabel { get; set; }
        public decimal? PosizioneCampo { get; set; }
        public string NomeCampoIsvap { get; set; }
        public string DescrizioneErrore { get; set; }
        public decimal? LunghezzaCampo { get; set; }
        public string DescrizioneBreve { get; set; }
    }
}
