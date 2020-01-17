using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabOperazioni
    {
        public TabOperazioni()
        {
            TabOperazioniLinee = new HashSet<TabOperazioniLinee>();
            TabParametriOperazioni = new HashSet<TabParametriOperazioni>();
        }

        public decimal IdTabOperazione { get; set; }
        public decimal Codice { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Url { get; set; }
        public string FlgVisibileSino { get; set; }
        public string FlgModificaPtfSino { get; set; }
        public string FlgGeneraPremioSino { get; set; }
        public string FlgPropostaSino { get; set; }
        public string FlgEventoEmissione { get; set; }
        public string FlgEventoProposta { get; set; }
        public string FlgTipoOperazione { get; set; }
        public string Descrizione { get; set; }
        public string FlgStornoOpPrecedentiSino { get; set; }

        public virtual ICollection<TabOperazioniLinee> TabOperazioniLinee { get; set; }
        public virtual ICollection<TabParametriOperazioni> TabParametriOperazioni { get; set; }
    }
}
