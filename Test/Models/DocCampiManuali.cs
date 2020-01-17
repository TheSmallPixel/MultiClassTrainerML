using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocCampiManuali
    {
        public decimal IdDocCampomanuale { get; set; }
        public string CodVariabile { get; set; }
        public string Label { get; set; }
        public string FlgTipoFormato { get; set; }
        public decimal? Dimensione { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public decimal? Sequenza { get; set; }
    }
}
