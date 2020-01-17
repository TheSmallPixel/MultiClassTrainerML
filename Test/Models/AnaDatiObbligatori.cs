using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaDatiObbligatori
    {
        public decimal IdDatiObbligatori { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdRuolo { get; set; }
        public decimal IdCampoAnagrafica { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public string FlgNonVisibileSino { get; set; }
        public string FlgTipoAnagrafica { get; set; }
    }
}
