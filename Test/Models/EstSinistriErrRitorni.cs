using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EstSinistriErrRitorni
    {
        public decimal IdErrore { get; set; }
        public string CodTipoErrore { get; set; }
        public string DescrizioneErrore { get; set; }
        public decimal? IdEstrazioneDett { get; set; }
        public decimal? IdEstrazione { get; set; }
        public string RecordRicevuto { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
