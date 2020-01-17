using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WkfOperazioni
    {
        public int IdOperazione { get; set; }
        public int? IdCompagnia { get; set; }
        public string CodOperazione { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public string Parametri { get; set; }
        public string Modulo { get; set; }
        public string CodTipoAttivita { get; set; }
    }
}
