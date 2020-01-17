using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysParametriProcessi
    {
        public decimal IdParametroProcesso { get; set; }
        public decimal IdProcesso { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public decimal? Dimensione { get; set; }
        public string CodFlagSistema { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal Ordine { get; set; }
        public string Descrizione { get; set; }

        public virtual SysProcessi IdProcessoNavigation { get; set; }
    }
}
