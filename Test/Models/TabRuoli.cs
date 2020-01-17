using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRuoli
    {
        public TabRuoli()
        {
            AnaRuoli = new HashSet<AnaRuoli>();
            TabPubblicaAnagrafiche = new HashSet<TabPubblicaAnagrafiche>();
        }

        public decimal IdRuolo { get; set; }
        public string CodRuolo { get; set; }
        public decimal IdDescrizione { get; set; }
        public string FlgUtilizzabileSino { get; set; }
        public string FlgSelezionaIndirizzoSino { get; set; }
        public string TableName { get; set; }
        public string FlgSoggettoABloccoSino { get; set; }
        public string Descrizione { get; set; }
        public string FlgRicercaSinistriSino { get; set; }
        public string FlgRicercaPolizzeSino { get; set; }
        public string FlgRichiediIdFiscaleSino { get; set; }
        public string FlgFiltraNazioneSino { get; set; }

        public virtual ICollection<AnaRuoli> AnaRuoli { get; set; }
        public virtual ICollection<TabPubblicaAnagrafiche> TabPubblicaAnagrafiche { get; set; }
    }
}
